var io = 1;
var unsc = 5;
var ungoi = 1;
if(io < unsc){
    switch(io)
    {
        case 1:
            if(io < unsc){
                console.log("io es menor que unsc ");
            }else{
                switch(unsc){
                    case 1:
                        console.log("unsc es 1");
                        break;
                        case 2:
                            console.log("unsc es 2");
                            break;
                }
            }
            break;
            case 2:
                console.log("io es igual a unsc");
                break;
            case ungoi:
                console.log("El ungoi es pequeño");
                break;
                default:
                    console.log("io no es igual a c1 o c2, pero es igual a ungoi");
                    break;
        }
    }else{
        console.log("io es menor que unsc");
    }
