from tkinter import *
from tkinter import filedialog
from PIL import Image
from PIL import ImageTk
import cv2



# Define form
form = Tk()
# This is title of form
form.title("Age & Gender Detection System")
# This is width and height of form
form.geometry('630x500')
# Set Form Background color
form.configure(background="SkyBlue")

filepath = StringVar(form, value='')
genderResult = StringVar(form, value='')
ageResult = StringVar(form, value='')
lblGender= StringVar(form, value='')
lblAge= StringVar(form, value='')

lblHeading = Label(form, text="Age & Gender Detection Using Image", fg="White", bg="Purple", font=("Helvetica", 16))
lblHeading.grid(row=0,column=2, pady="10" )


# Choose File Click Event
def chooseFileClick():
    form.filename = filedialog.askopenfilename(initialdir="/", title="Select Image",
                                               filetypes=(("jpeg files", ".jpg"), ("all files", ".*")))
    filepath.set(form.filename)
    lblGender.set('Gender is :')
    lblAge.set('Age is :')
    imageProcessing(form.filename,False)
def chooseLiveClick():
    filepath.set("")
    genderResult.set('')
    ageResult.set('')
    lblGender.set('')
    lblAge.set('')
    imageProcessing("",True)

# Creating a photoimage object to use image 
LiveCapIcon = PhotoImage(file = r"videocap.png")
imageIcon = PhotoImage(file = r"imageicon.png")

chooseLiveCap = Button(form, text="Live Screen Capturing",fg="white", bg="Black",image = LiveCapIcon, compound=LEFT, command=chooseLiveClick).grid(row=1, column=3,  padx=10, pady=10)
lblChooseFile = Label(form, text="Select Image ", bg="SkyBlue", font=("Helvetica", 12)).grid(row=2, column=1)
# lblChooseFile.pack(side=LEFT)
lblChooseFileTxt = Entry(form, textvariable=filepath, width="50", state='disabled').grid(row=2, column=2)
# lblChooseFileTxt.pack(side=LEFT)
ChooseFile = Button(form, text="Choose Image",fg="white", bg="Green", image = imageIcon, compound=LEFT,command=chooseFileClick).grid(row=2, column=3)
# ChooseFile.pack(side=LEFT)

ageLbl = Label(form, textvariable=lblAge, bg="SkyBlue", font=("Helvetica", 14)).grid(row=3, column=1)
genderLbl = Label(form, textvariable=lblGender, bg="SkyBlue", font=("Helvetica", 14)).grid(row=4, column=1)

ageResult1 = Label(form, textvariable=ageResult, bg="SkyBlue", font=("Helvetica", 14)).grid(row=3, column=2)
genderResult1 = Label(form, textvariable=genderResult, bg="SkyBlue", font=("Helvetica", 14)).grid(row=4, column=2)


# canvas = Canvas(form, width = 300, height = 300)
# canvas.grid( row = 2 , column = 1)

def highlightFace(net, frame, conf_threshold=0.7):
    #creating shallow copy & get hieight and width
    frameOpencvDnn = frame.copy()
    frameHeight = frameOpencvDnn.shape[0]
    frameWidth = frameOpencvDnn.shape[1]
    #create blob from shallow copy
    blob = cv2.dnn.blobFromImage(frameOpencvDnn, 1.0, (300, 300), [104, 117, 123], True, False)

    net.setInput(blob)
    detections = net.forward()
    faceBoxes = []
    for i in range(detections.shape[2]):
        confidence = detections[0, 0, i, 2]
        if confidence > conf_threshold:
            x1 = int(detections[0, 0, i, 3] * frameWidth)
            y1 = int(detections[0, 0, i, 4] * frameHeight)
            x2 = int(detections[0, 0, i, 5] * frameWidth)
            y2 = int(detections[0, 0, i, 6] * frameHeight)
            faceBoxes.append([x1, y1, x2, y2])
            cv2.rectangle(frameOpencvDnn, (x1, y1), (x2, y2), (0, 255, 0), int(round(frameHeight / 150)), 8)
    return frameOpencvDnn, faceBoxes


def imageProcessing(filepath,isCapturing):
    faceProto = "opencv_face_detector.pbtxt"
    faceModel = "opencv_face_detector_uint8.pb"
    ageProto = "age_deploy.prototxt"
    ageModel = "age_net.caffemodel"
    genderProto = "gender_deploy.prototxt"
    genderModel = "gender_net.caffemodel"

    MODEL_MEAN_VALUES = (78.4263377603, 87.7689143744, 114.895847746)
    ageList = ['(0-2)', '(4-6)', '(8-12)', '(15-20)', '(25-32)', '(38-43)', '(48-53)', '(60-100)']
    genderList = ['Male', 'Female']

    faceNet = cv2.dnn.readNet(faceModel, faceProto)
    ageNet = cv2.dnn.readNet(ageModel, ageProto)
    genderNet = cv2.dnn.readNet(genderModel, genderProto)

    if not isCapturing:
        video = cv2.VideoCapture(filepath if filepath else 0)
    else:
        video = cv2.VideoCapture(0)
    #Set padding to 20
    padding = 20
    while cv2.waitKey(1) < 0:
        hasFrame, frame = video.read()
        if not hasFrame:
            cv2.waitKey()
            break

        resultImg, faceBoxes = highlightFace(faceNet, frame)
        if not faceBoxes:
            result = "Sorry no face detected"
            genderResult.set("No face detected")
            ageResult.set("No face detected")
            print("No face detected")

        for faceBox in faceBoxes:
            face = frame[max(0, faceBox[1] - padding):
                         min(faceBox[3] + padding, frame.shape[0] - 1), max(0, faceBox[0] - padding)
                                                                        :min(faceBox[2] + padding,
                                                                             frame.shape[1] - 1)]
            # Get Face
            blob = cv2.dnn.blobFromImage(face, 1.0, (227, 227), MODEL_MEAN_VALUES, swapRB=False)
            genderNet.setInput(blob)
            genderPreds = genderNet.forward()
            gender = genderList[genderPreds[0].argmax()]
            result = f'Gender: {gender}'
            genderResult.set(gender)
            print(f'Gender: {gender}')

            ageNet.setInput(blob)
            agePreds = ageNet.forward()
            age = ageList[agePreds[0].argmax()]
            print(f'Gender: {gender} and age:{age[1:-1]} years')
            ageResult.set(f'{age[1:-1]} years')

            cv2.putText(resultImg, f'{gender}, {age}', (faceBox[0], faceBox[1] - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.8,
                        (0, 255, 255), 2, cv2.LINE_AA)

            if isCapturing:
                # print ("In  Ifff ",isCapturing)
                cv2.imshow("Detecting age and gender", resultImg)
            else:
                # print ("Inelseee:",isCapturing)
                # convert the images to PIL format...
                image = Image.fromarray(resultImg)
                # ...and then to ImageTk format
                image = ImageTk.PhotoImage(image.resize((300, 300)))
                # update the pannels
                panel = Label(form, image=image).grid(row=5, column=2)
                panel.configure(image=image)
                panel.image = image

if cv2.waitKey(1) & 0xFF == ord('q'):
    cv2.destroyAllWindows()
form.mainloop()

