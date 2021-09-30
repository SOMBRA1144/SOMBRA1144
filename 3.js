var q = 10;
var w = 15;
var gato = "animal";
if(q > w){
    console.log("q es menor a w");
}else{
    console.log("q es mayor a w");
}

switch(gato){
    case "gato":
        console.log("El gato es un animal");
    break;
    case "gato":
        console.log("El gato duerme");
    break;
    case "gato":
        console.log("El gato es un animal");
    break;
    default:
        console.log("El gato come");
    break;
}