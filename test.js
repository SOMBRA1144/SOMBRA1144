var x = 10;
var y = 20;
var perro = "Firulais";
if(x < y){
    console.log("x es menor a y");
}else{
    console.log("x es mayor a y");
}

switch(perro){
    case "perro":
        console.log("El perro es un animal");
    break;
    case "gato":
        console.log("El gato es un animal");
    break;
    case "Firulais":
        console.log("El perro es un gato");
    break;
    default:
        console.log("No es un animal");
    break;
}