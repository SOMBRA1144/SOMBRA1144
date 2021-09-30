var j = 10;
var k = 15;
var perro = "animal";
if(j < k){
    console.log("j es menor a k");
}else{
    console.log("j es mayor a k");
}

switch(perro){
    case "animal":
        console.log("El perro es un animal");
    break;
    case "perro":
        console.log("El perro ladra");
    break;
    case "perro":
        console.log("El perro es un animal");
    break;
    default:
        console.log("El perro come");
    break;
}