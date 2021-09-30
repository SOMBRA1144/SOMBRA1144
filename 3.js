var q = 100;
var w = 120;
if(q < w){
    switch(q)
    {
        case 1:
            if(q < w){
                console.log("q es menor que w ");
            }else{
                switch(w){
                    case 16:
                        console.log(" es 120");
                        break;
                        case 20:
                            console.log("w es 20");
                            break;
                }
            }
            break;
            case 2:
                console.log("q es igual a w");
                break;
                default:
                    console.log("q no es igual a c1 o c2 ");
                    break;
        }
    }else{
        console.log("q es menor que w");
    }