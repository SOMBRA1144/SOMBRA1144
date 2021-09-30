var m = 100;
var n = 150;
var humano = "persona";
if(m < n){
    console.log("m es menor a n");
}else{
    console.log("m es mayor a n");
}

switch(humano){
    case "persona":
        console.log("El humano es una persona");
    break;
    case "humano":
        console.log("El humano crea");
    break;
    case "humano":
        console.log("El humano es un animal");
    break;
    default:
        console.log("El humano vive");
    break;
}