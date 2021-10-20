
var audio = document.createElement("AUDIO")
document.body.append(audio);
audio.src = "../Audio/Hopless-waltz.mp3"

document.body.addEventListener("mousemove", function () {
    audio.play()
})