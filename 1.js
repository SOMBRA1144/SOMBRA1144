var x = 20;
var y = 30;
var grunt = "enemigo";
if(x < y){
    console.log("x es menor a y");
}else{
    console.log("x es mayor a y");
}

switch(grunt){
    case "grunt":
        console.log("El grunt es un enemigo");
    break;
    case "halo":
        console.log("El halo es un arma");
    break;
    case "grunt":
        console.log("Eel grunt es un arma");
    break;
    default:
        console.log("No es un aliado");
    break;
}