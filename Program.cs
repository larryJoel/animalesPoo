class Program {
    public static void Main() {
        var miPerro = new Perro();
         miPerro.caminar();
         miPerro.comer();
        Console.WriteLine("hagamos que el perro viva");
        miPerro.vivir();   

        var texto = miPerro.ToString();


    
    }
}
