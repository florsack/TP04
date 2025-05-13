namespace TP04;
public static class Ahorcado{
    public static string palabra {private set; get;}
    public static List<string> letras {private set; get;} = new List<string>();
    public static List<string> letrasEncontradas {private set; get;} = new List<string>();

    public static void inicializarAhorcado(){
        palabra = "Florencia";
        letras.Clear();
        foreach (char i in palabra){
            letras.Add(i.ToString());
        }
    }
    public static void chequearLetra(string l){
        if (letras.Contains(l)){

        }
    }
}