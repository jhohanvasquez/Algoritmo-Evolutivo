En este ejercicio vamos a implementar un algoritmo evolutivo, los pasos se describen a continuación:

⦁	Iniciar con una cadena aleatoria de 30 caracteres.
⦁	Realizar 100 copias de la cadena inicial, teniendo en cuenta que cada carácter en la cadena copiada tendrá un 5% de probabilidad de que sea reemplazado por un nuevo carácter aleatorio.
⦁	Comparar cada una de las 100 cadenas generadas con el texto “ESTO ES UN ALGORITMO EVOLUTIVO”, y dar a cada cadena un puntaje. El puntaje corresponde al  número de caracteres en la cadena copiada que se corresponden con el texto “ESTO ES UN ALGORITMO EVOLUTIVO”. Por ejemplo el puntaje para la cadena “ESTY ES UNKALGORITMO EVOLRTIVO” es 26 (hay 4 caracteres incorrectos entre los 30).
⦁	Si alguna de las cadenas generadas tiene un puntaje perfecto (30 puntos), el algoritmo termina.
⦁	De otro modo, se debe tomar la cadena (entre las 100 generadas) que tenga el puntaje más alto y volver al paso 2, tomando dicha cadena como punto de partida.
⦁	Cada iteración de este algoritmo se conoce como una Generación. Se requiere mostrar en pantalla la cadena con el puntaje más alto de cada generación.
⦁	Para propósitos de este algoritmo, un carácter es cualquier letra en mayúscula, o un espacio en blanco.
⦁	Los caracteres correctos de cada generación no se bloquean, esto quiere decir que un carácter correcto se podría volver incorrecto en las generaciones subsecuentes

Ejemplo:
Generación:  0 - Mutación: RFXLIYGKDOUIWJKPIJAZAPSSNIPHYT - Puntaje: 1
Generación:  1 - Mutación: RFXLIYG DOLIWJKPIJAZSPSSNIPHYO - Puntaje: 3
Generación:  2 - Mutación: RFXLIYG DOLIWJKPIJVZSESSNIPOYO - Puntaje: 4
Generación:  3 - Mutación: RFXL YG DOLNWJKPIJVZEESSNIPOYO - Puntaje: 5
...
Generación: 19 - Mutación: RSTO ES EN OLJOPITVOEEVOLUPIYO - Puntaje: 21
Generación: 20 - Mutación: ESTO ES EN OLJO ITVOEEVOLUPIYO - Puntaje: 22
Generación: 21 - Mutación: ESTO ES EN OLJO ITVOEEVOLUTIYO - Puntaje: 23
...
Generación: 89 - Mutación: ESTO ES UN ALJORITMO EVOLUTIVO - Puntaje: 29
Generación: 90 - Mutación: ESTO ES UN ALGORITMO EVOLUTIVO - Puntaje: 30
