var x = 60;
var y = 55;
var c = "p";
if(x > y){
    switch(x)
    {
        case 1:
            if(x > y){
                console.log("x es mayor que y ");
            }else{
                switch(y){
                    case 16:
                        console.log("y es 55");
                        break;

                        case 55:
                            console.log("y es 55");
                            break;
                }
            }
            break;
            case 55:
                console.log("x es igual a y");
                break;
            case c:
                console.log("No hase nada");
                break;
                default:
                    console.log("x no es igual a c16, c55 o c");
                    break;
        }
    }else{
        console.log("x es mayor que y");
    }
