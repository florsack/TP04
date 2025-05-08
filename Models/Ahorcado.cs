namespace TP04;
public static class Ahorcado{
    public static string palabra {public set; get;} 
    public static List<char> letras {public set; get;}
    public static void inicializarAhorcado(){
        palabra = "Florencia";
        letras.Clear();
        foreach (char i in palabra){
                    letras.add(i);
        }
    }
}