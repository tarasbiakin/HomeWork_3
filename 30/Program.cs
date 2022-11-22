//Заполнить массив случайными числами 

int[]array = new int[8];

void RandArray(int[]arr){

Random rnd = new Random();    
for(int i= 0; i<arr.Length;i++)
{
array[i] = rnd.Next(0,2);

}
}
void PrintArrau(int[]arr){
   for(int i= 0; i<arr.Length;i++)
   { 
    Console.Write($"{array[i]} ");
   }
}
RandArray(array);
PrintArrau(array);

