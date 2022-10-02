class Animal{
public void caminar() {
           Console.WriteLine("Soy un animal y estoy caminando");
    }
      virtual public void comer() {
           Console.WriteLine("Soy un animal y estoy comiendo");
    }
    virtual public void crecer() {
        Console.WriteLine("Soy un animal y estoy creciendo");
    }
    public void vivir(){
        caminar();
        comer();
        crecer();
        caminar();
    }
}