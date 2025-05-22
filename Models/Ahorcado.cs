namespace TP04;
public  class Ahorcado{
    public  string palabra {private set; get;}
    public  List<string> letras {private set; get;} = new List<string>();
    public  List<string> ingresosMalos {private set; get;} = new List<string>();
    public  List<string> letrasEncontradas {private set; get;} = new List<string>();
    public  int intentos {private set; get;}


    public  void inicializarAhorcado(){
        palabra = "florencia";
        intentos = 0;
        letras.Clear();
        foreach (char i in palabra){
            if(!letras.Contains(i.ToString())){
                letras.Add(i.ToString());
            }
        }
    }
    public  void chequearLetra(string l){
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
    public  bool chequearPalabra(string palabraArriesgada){
        bool sonIguales = false;
        if (palabraArriesgada != null){
            if(palabra == palabraArriesgada.ToLower()){
                sonIguales = true;
            }else{
                intentos++;
            }
        }else{
            List<string> letrasOriginalesOrdenadas = new List<string>();
            foreach (string l in letras){
                letrasOriginalesOrdenadas.Add(l);
            }
            letrasOriginalesOrdenadas.Sort();
            List<string> letrasIngresadasOrdenadas = new List<string>();
            foreach (string l in letrasEncontradas){
                letrasIngresadasOrdenadas.Add(l);
            }
            letrasIngresadasOrdenadas.Sort();
            if (letrasOriginalesOrdenadas.Count == letrasIngresadasOrdenadas.Count) {
                bool iguales = true;
                for (int i = 0; i < letrasOriginalesOrdenadas.Count; i++) {
                    if (letrasOriginalesOrdenadas[i] != letrasIngresadasOrdenadas[i]) {
                        iguales = false;
                        break;
                    }
                }
                if (iguales) {
                    sonIguales = true;
                }
            }
        }
        return sonIguales;
    }

    
}