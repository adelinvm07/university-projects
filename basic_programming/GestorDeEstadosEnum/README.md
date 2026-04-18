# Gestor de estados de un sistema
## Objetivo
Esta práctica tiene como propósito principal entender el uso e importancia de los enumeradores en la programación.

## ¿Qué hace el programa?
Permite a un usuario ingresar por consola una cantidad de clientes indefinida 
(esto gracias al uso de las listas); luego de esto, puede verificar todos los clientes registrados en el sistema. 
Además, se puede buscar al cliente por ID y hasta modificar el estado de la solicitud de cualquier cliente
cuando sea necesario. Todo esto bajo las mejores prácticas y verificando que los datos ingresados sean correctos (evitando
que en una variable tipo int se intente almacenar un string o cualquier otro no soportado).

## ¿Qué son los enumeradores?
Un enumerador es una estructura que permite asignarle nombres significativos a valores numéricos constantes, 
esto con el objetivo de hacer el código más legible y evitar el uso de números sin contexto.

## Uso de enumeradores 
En el programa se utilizan dos enumeradores, uno para el menú inicial de los procesos que puede realizar el usuario y otro
para los estados en los que se pueden encontrar los procesos (dígase en proceso, cancelado, etc.). 
Estos facilitan la lectura del código y el mantenimiento del mismo. Si estos no fuesen implementados aquí, 
deberíamos memorizar en qué número dijimos que estaría cierta actividad o hasta nos arriesgaríamos a que el 
mismo usuario por consola digite supuestos estados del proceso que tienen algún error (ya sea ortográfico o lógico). 

## Capturas de pantalla en distintos escenarios

### Escenario 1 : Registrar dos clientes 
#### 1.1. Prueba en que los clientes son registrados exitosamente
<img width="946" height="640" alt="image" src="https://github.com/user-attachments/assets/63738398-3d96-4c71-b8d8-c2a671fde979" />

#### 1.2. Prueba de cuando se intentan registrar clientes con valores nulos o incorrectos para el tipo de dato
<img width="1047" height="650" alt="image" src="https://github.com/user-attachments/assets/e254a998-7b38-4acf-9111-43da7d2d7703" />

#### 1.3. Prueba cuando se ingresa un ID repetido
<img width="629" height="325" alt="image" src="https://github.com/user-attachments/assets/04f3d889-18cd-4246-a2fd-cd54ed79963d" />

### Escenario 2 : Mostrar todos los clientes registrados en el sistema
#### 2.1. Prueba cuando hay clientes registrados 
<img width="707" height="569" alt="image" src="https://github.com/user-attachments/assets/8684860d-c6be-488a-949a-5bc20753cddc" />

#### 2.2. Prueba cuando no hay clientes registrados 
<img width="573" height="372" alt="image" src="https://github.com/user-attachments/assets/66b9ca9a-5d8d-41ae-b76e-8e2939bae66a" />

### Escenario 3 : Buscar a un cliente por su ID
#### 3.1. Prueba cuando se ingresa un ID existente
<img width="740" height="432" alt="image" src="https://github.com/user-attachments/assets/b848493c-2c6a-4b6f-9d42-5f1788bf0929" />

#### 3.2. Prueba cuando se ingresa un ID no existente
<img width="783" height="301" alt="image" src="https://github.com/user-attachments/assets/13b35bc5-bb77-46a0-9cd3-83f383fbdafd" />

### Escenario 4 : Modificar el estado del proceso de un cliente 
#### 4.1. Prueba cuando modificamos el estado de un cliente existente 
##### Antes de ser modificado 
<img width="873" height="599" alt="image" src="https://github.com/user-attachments/assets/ad896ece-fbf1-4314-8961-82f1b062e50d" />

##### Luego de modificarse 
<img width="718" height="371" alt="image" src="https://github.com/user-attachments/assets/59f84d5f-8dde-4466-8c3c-8dde8e8eb3cd" />

#### 4.2. Prueba cuando no hay clientes registrados
<img width="594" height="273" alt="image" src="https://github.com/user-attachments/assets/65e5f639-ad78-4432-900c-7b72d7d7c66f" />


 
