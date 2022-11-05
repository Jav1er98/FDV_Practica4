## Práctica 4: Eventos y Movimiento rectilíneo.
## Objetivo: Resolver las siguientes actividades.

1. Crear un script para mover al objeto jugador con los ejes Horizontal y Vertical.
      
      - Esto ya lo hemos realizado en la práctica anterior, con lo que aprovechamos para mover con el cubo con el script MovePlayer.cs usando las teclas AWSD y las flechas del teclado para que se mueva de forma vertical y horizontal con la función Slerp de Quaternion como novedad ya que mira la dirección en la que se mueve.

      ![gif ejercicio 1](/gifs/Ejercicio1.gif)
      
2. Implementar una UI que permita configurar con qué velocidad te moverás: turbo o normal. También debe mostar la cantidad de objetos recolectados y si chocas con alguno especial restar fuerza. 
      - Crearemos un Canvas el cual nos permitirá asginar nuestra UI que estará formada por varios textos y dos botones que serán los de "Turbo" y "Normal" a los cuales les asginaremos las funciones ya establecidas en en Moveplayer.cs que harán que se modifique la velocidad a la que se desplaza el cubo
      
      ![gif ejercicio 2_1](/gifs/Ejercicio2_1.gif)
      
      - Las esferas amarillas tienen un OnTriggerEnter para detectar si el jugador ha entrado en su collider, y esto genera la llamada a un gameManager.cs para cambiar el valor de las esferas recolectadas en la interfaz.
      
      ![gif ejercicio 2_2](/gifs/Ejercicio2_2.gif)
      
      - Con los cilindros tendremos un OnCollisionEnter que llama también al GameManager para quitarle "fuerza" que en mi caso llamamos "Health" quitandole 10 de vida por cada colisión y actualiza el texto de la interfaz.
      
      ![gif ejercicio 2_4](/gifs/Ejercicio2_4.gif)

3. Agregar a tu escena un objeto que al ser recolectado por el jugador haga que otro objetos obstáculos se desplacen de su trayectoria. 
      - El cubo azul será nuestro notificador contiene un delegado y activa el evento OnRecolect y lo llama usando OnTriggerEnter. Las 3 esferas verdes serán los suscriptores que reaccionan a la llamada del evento y activan una la función addForce que les añade una fuerza para desplazarlas.
    
      ![gif ejercicio 2_3](/gifs/Ejercicio2_3.gif)
       
4. Agrega un objeto que te teletransporte a otra zona de la escena.
      -  Tenemos dos cilindros azules, que contienen el script Teleport.cs, cada uno contiene un referencia al otro, cuando el cubo entra en su collider, se le cambia la posición hasta el otro. Evitamos que cambie su posición constantemente hasta que salga del colider con la etique OnTriggerExit.
      
      ![gif ejercicio 4](/gifs/Ejercicio4.gif)
      
5. Agrega un personaje que se dirija hacia un objetivo estático en la escena.

      - Hemos cogido el código de la práctica anterior para realizar este paso Follow.cs, calculando la posición del objeto a mover y la del objetivo restamos la posiciones y se calcula el vector entre estos dos para moverse.

      ![gif ejercicio 5](/gifs/Ejercicio5.gif)
      
6. Agrega un personaje que siga el movimiento del jugador. 
     - Combianos dos scripts utilizados anteriormente para llevar a cabo este último paso poniendo de Target a la esfera el cubo, con la diferencia en que en la esfera hemos utilizado el Slerp para probar si habría mucha diferencia al seguir al cubo.
           
      ![gif ejercicio 6](/gifs/Ejercicio6.gif)
