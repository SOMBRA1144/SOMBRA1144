var a = 10;
var b = 15;

if(a < b){
    switch(a)
    {
        case 1:
            if(a < b){
                console.log("a es menor que b ");
            }else{
                switch(b){
                    case 16:
                        console.log("b es 16");
                        break;
                        case 20:
                            console.log("b es 20");
                            break;
                }
            }
            break;
            case 2:
                console.log("a es igual a b");
                break;
            case "gato":
                console.log("Acaricia al gato");
                break;
                default:
                    console.log("a no es igual a c1, c2 o gato");
                    break;
        }
    }else{
        console.log("a es menor que b");
    }
