class Perro : Animal {
        public override void comer() {
          Console.WriteLine("Soy un perro y estoy comiendo");
      }

      new public void caminar() {
          Console.WriteLine("Soy un perro y estoy corriendo");
      }
}