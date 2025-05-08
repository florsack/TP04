namespace TP04;
public static class Ahorcado{
    public static string palabra {private set; get;}
    public static List<char> letras {private set; get;} = new List<char>();

    public static void inicializarAhorcado(){
        palabra = "Florencia";
        letras.Clear();
        foreach (char i in palabra){
            letras.Add(i);
        }
    }
}