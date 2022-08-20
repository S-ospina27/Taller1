
 
 Console.WriteLine("porfavor ingrese el primer valor semestral");
 double Vl1=double.Parse(Console.ReadLine());
 Console.WriteLine("porfavor ingrese el segundo valor semestral");
 double Vl2=double.Parse(Console.ReadLine());
  double Vlrrenta=(Vl1+Vl2);
 Console.WriteLine("El valor de su renta anual es:"+Vlrrenta+"$");



if( Vlrrenta<10000){
    Console.WriteLine("el total de renta apagar es:"+(Vlrrenta*0.05)+"$ \n"+"y el % de impuesto apagar fue del: 5% ");

}
if( Vlrrenta>=10000 && Vlrrenta<20000 ){
    Console.WriteLine("el total de renta apagar es:"+(Vlrrenta*0.10)+"$ \n"+"y el % de impuesto apagar fue del: 10% ");
}
if( Vlrrenta>=20000 && Vlrrenta<35000 ){
    Console.WriteLine("el total de renta apagar es:"+(Vlrrenta*0.15)+"$ \n"+"y el % de impuesto apagar fue del: 15% ");
}
if( Vlrrenta>=35000 && Vlrrenta<45000 ){
    Console.WriteLine("el total de renta apagar es:"+(Vlrrenta*0.20)+"$ \n"+"y el % de impuesto apagar fue del: 20%");
}
if(Vlrrenta>=45000 ){
    Console.WriteLine("el total de renta apagar es:"+(Vlrrenta*0.30)+"$ \n"+"y el % de impuesto apagar fue del: 30%");
}





