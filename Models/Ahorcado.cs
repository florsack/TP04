namespace TP04;
public static class Ahorcado{
    public static string palabra {private set; get;}
    public static List<string> letras {private set; get;} = new List<string>();
    public static List<string> ingresosMalos {private set; get;} = new List<string>();
    public static List<string> letrasEncontradas {private set; get;} = new List<string>();
    public static int intentos {private set; get;}


    public static void inicializarAhorcado(){
        palabra = "florencia";
        intentos = 0;
        letras.Clear();
        foreach (char i in palabra){
            if(!letras.Contains(i.ToString())){
                letras.Add(i.ToString());
            }
        }
    }
    public static void chequearLetra(string l){
        if (l!=null){
            if (letras.Contains(l.ToLower())){
                if (!letrasEncontradas.Contains(l.ToLower())){
                    letrasEncontradas.Add(l.ToLower());
                }
            } else {
            if(!ingresosMalos.Contains(l.ToLower())){
                ingresosMalos.Add(l.ToLower());
            }
            intentos++;
            }
        }
    }
    public static bool chequearPalabra(string palabraArriesgada){
        bool sonIguales = false;
        if (palabraArriesgada != null){
            if(palabra == palabraArriesgada.ToLower()){
                sonIguales = true;
            }else{
                intentos++;
            }
        }else{
            List<string> letrasOriginalesOrdenadas = new List<string>();
            letrasOriginalesOrdenadas = letras;
            letrasOriginalesOrdenadas.Sort();
            List<string> letrasIngresadasOrdenadas = new List<string>();
            letrasIngresadasOrdenadas = letrasEncontradas;
            letrasIngresadasOrdenadas.Sort();
            if(letrasOriginalesOrdenadas == letrasIngresadasOrdenadas){
                sonIguales = true;
            }
        }
        return sonIguales;
    }

    
}