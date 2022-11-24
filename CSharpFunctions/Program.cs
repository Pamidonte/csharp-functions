// See https://aka.ms/new-console-template for more information

//definisco un array di interi 
int[] arrayInteri = { 1, 2, 3, 4, 5, 6, 7 };

//stampo gli elementi dell array formattati [elemento 1, elemento 2, elemento 3, ...]
stampaArrayInteri(arrayInteri);

//dichiaro la variabile che passata a una funzione ci restituirà il suo quadrato
int numero = 5;

Console.Write("\n" + quadrato(numero));

//stampo l array elevato al quadrato
stampaArrayInteri(elevaArrayAlQuadrato(arrayInteri));

//controllo che l array originale non sia stato modificato
stampaArrayInteri(arrayInteri);

//stampo la somma degli elementi dell array
Console.WriteLine("\n" + sommaElementiArray(arrayInteri));

//stampo la somma di tutti i numeri elevati al quadrato
Console.WriteLine("\n" + sommaElementiArray(elevaArrayAlQuadrato(arrayInteri)));



// definisco una funzione per la somma dei numeri nell array
int sommaElementiArray(int[] array)
{
    int sommaTotale = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sommaTotale = sommaTotale + array[i];
    }
    return sommaTotale;
}

// definisco la funzione che eleva i numeri dell array al quadrato
int[] elevaArrayAlQuadrato(int[] array)
{
    // definisco un nuovo array della stessa lunghezza dell array passato come parametro diversamente dall esempio visto questa mattina
    int[] arrayQuadrato = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int numeroAlQuadrato = quadrato(array[i]);
        arrayQuadrato[i] = numeroAlQuadrato;
    }
    return arrayQuadrato;
}

//dichiaro la funzione che restituisce il quadrato
int quadrato(int numeroIntero)
{
    return numeroIntero * numeroIntero;
}

// definisco la funzione che stampa gli elementi dell array
void stampaArrayInteri(int[] arrayNumero)
{

    Console.Write("\n[");

    for (int i = 0; i < arrayNumero.Length; i++)
    {
        if (i == arrayNumero.Length - 1)
        {
            Console.Write(arrayNumero[i]);

        }
        else
        {
            Console.Write(arrayNumero[i] + ",");
        }

    }
    Console.Write("]");
}
