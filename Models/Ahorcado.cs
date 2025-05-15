namespace TP04;
public static class Ahorcado{
    public static string palabra {private set; get;}
    public static List<string> letras {private set; get;} = new List<string>();
    public static List<string> letrasEncontradas {private set; get;} = new List<string>();

    public static void inicializarAhorcado(){
        palabra = "florencia";
        letras.Clear();
        foreach (char i in palabra){
            letras.Add(i.ToString());
        }
    }
    public static void chequearLetra(string l){
        if (letras.Contains(l.ToLower())){
            if(!letrasEncontradas.Contains(l)){
                letrasEncontradas.Add(l);
            }
        }
    }
    public static bool chequearPalabra(string palabraArriesgada){
        bool sonIguales = false;
        if(palabra == palabraArriesgada){
            sonIguales = true;
        } else if (letras == letrasEncontradas){
            sonIguales = true;
        }
        return sonIguales;
    }
}