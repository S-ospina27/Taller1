
Console.Write("ingrese su nombre completo ");
string Nombre= Console.ReadLine();
Console.Write("ingrese su edad ");
uint Edad=uint.Parse(Console.ReadLine());



if(Edad<4){
  Console.Write("el niño de nombre:" +Nombre+"\n puede entrar gratis  ya que su edad es menor de :4Años");
}
if(Edad >=4 && Edad<=18){
  Console.Write("el niño de nombre:" +Nombre+"\n ya que la edad esta entre 4 y los 18 Años la entrada le cuesta:"+(15000*0.95)+"$");
}

if( Edad>18){
  Console.Write("el niño de nombre:" +Nombre+"\n ya que es mayor de 18 Años la entrada le cuesta:"+(15000*0.98)+"$");
}

