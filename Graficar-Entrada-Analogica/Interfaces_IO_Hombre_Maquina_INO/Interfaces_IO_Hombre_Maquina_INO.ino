/*****
* Author: Hazael Fernando Mojica Garcia
* FIME, UANL, Mexico
* Interfaces IO Hombre Maquina
* 18/ago/2016
*****/

int Get_Instruccion();
void Analog_Read();

void setup()
{//Setup: Establecer la comunicación Serial
  Serial.begin(115200);
}

void loop()
{
  Get_Instruccion();
}


int Get_Instruccion()
{
  if(Serial.available())
  {
      switch(Serial.read())
      {
         case 'r'://Leer entrada analogica y mandar dato
           Analog_Read();
         break; 
      }
  }
}

void Analog_Read()
{
    int resultado = 0;
    resultado = analogRead(0); //Leemos el pin analogico 0 en 10bits
    Serial.write(resultado / 4); //Mandamos el resultado en 8bits por Serial
}
