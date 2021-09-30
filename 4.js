var parra = 1;
var nico = 1;
if(parra = nico){
    switch(parra)
    {
        case 1:
            if(parra = nico){
                console.log("parra es igual que nico ");
            }else{
                switch(nico){
                    case 1:
                        console.log("nico es 1");
                        break;

                        case 2:
                            console.log("nico es 2");
                            break;
                }
            }
            break;
            case 2:
                console.log("parra es igual a nico");
                break;

                default:
                    console.log("parra no es igual a c1 o c2 ");
                    break;
        }
    }else{
        console.log("parra es igual que nico");
    }