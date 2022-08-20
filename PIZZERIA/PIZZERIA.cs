// bloque inicio tipo de pizza
Console.Write("¿Desea una pizza vegetaria? \n 1)-SI \n 2)-NO\n");
uint opcion=uint.Parse(Console.ReadLine());
bool validar = opcion==1 ? true : false;

// bloque seleccion ingredientes
uint seleccion_ingrediente = 0;
string ingrediente = "";

if(validar == true){
    Console.Write("Seleccione un ingrediente: \n 1)-pimiento \n 2)-champiñones \n");
    seleccion_ingrediente = uint.Parse(Console.ReadLine());
    ingrediente = seleccion_ingrediente == 1 ? "Pimiento" : "Champiñones";
    Console.Write("Pizza Vegetariana: Mozzarella, Tomate y " + ingrediente);
} else {
    Console.Write("Seleccione un ingrediente: \n 1)-Pepperoni \n 2)-salami \n 3)-pollo \n");
    seleccion_ingrediente = uint.Parse(Console.ReadLine());
    ingrediente = seleccion_ingrediente == 1 ? "Pepperoni" : (seleccion_ingrediente == 2 ? "Salami" : "Pollo");
    Console.Write("Pizza: Mozzarella, Tomate y " + ingrediente);
}

//FIN BLOQUE 