# SESION-1-examen-interfaces

## Ejercicio 1. Crear una escena en la que el entorno se construya con el paquete The Shed de la Asset Store. Debes incluir al menos 3 arañas del paquete Free Fantasy Spider distribuidas por toda la habitación. Incluir un personaje del paquete Hungry Zombie. 
Se ha creado la escena según lo propuesto.

![Vídeo sin título (1)](https://github.com/Francisco-Marques-Armas/examen-interfaces/assets/72305337/9e51d302-fb72-4556-b79f-54a7c9b7b645)

## Ejercicio 2. Crear un script que actúe de controlador del movimiento del Zombie, avanzando siempre hacia delante del eje Z.
Se ha creado un controlador en el que siempre se avanza hacia delante, y las teclas wasd permiten rotar el personaje para cambiar su dirección.
![Vídeo sin título (2)](https://github.com/Francisco-Marques-Armas/examen-interfaces/assets/72305337/00f0dc3b-8869-42d2-b17c-2b2054a68071)

## Ejercicio 3. Crear un script para teletransportar al monstruo a cada vez que se pulse la tecla T.
Se ha añadido una parte en el controlador que permite teletransportar el jugador a una posición aleatoria dentro de un rango cuando se pulsa la tecla T.

![Vídeo sin título (3)](https://github.com/Francisco-Marques-Armas/examen-interfaces/assets/72305337/7e7ce4dd-76ab-4426-8898-a419da04b84b)

## Ejercicio 4. Crear un script que desplace aleatoriamente las macetas cada vez que el monstruo esté a una distancia que fijes de la pizarra y le acerque las sillas una distancia prefijada.
Se ha implementado la funcionalidad propuesta mediante eventos.

![Vídeo sin título (4)](https://github.com/Francisco-Marques-Armas/examen-interfaces/assets/72305337/54b5bdbf-b768-4b59-909a-21a9aa5e3b77)

## Ejercicio 5. Crear un script que al alcanzar el monstruo alguna silla todas las arañas se dirijan a él.
Se ha implementado la funcionalidad propuesta mediante eventos. Sin embargo, probando con la versión que tengo actualmente del proyecto, parece que se me ha olvidado poner la etiqueta "Spider" en las arañas y los colisionadores en las sillas en la entrega. Así es como debería funcionar habiendo hecho esos cambios:

![Vídeo sin título (5)](https://github.com/Francisco-Marques-Armas/examen-interfaces/assets/72305337/60c6307c-cacf-4a38-ad9b-18138925a6c2)

