# Pasos para instalar de dotnet core 2.2.
En este mini tutorial, dejare los pasos para instalar el NET CORE 2.2 en Visual Studio 2015 (community).

Primero que nada, bajaremos el SDK desde la pagina oficial de Microsoft, en el boton “Download .NET Core SDK”.

EL SDK queda instalado en esta ruta: C:\Program Files\dotnet
![dotnet image 1.png](https://tydw.files.wordpress.com/2019/04/dotnet-ruta-fisica.png)



Pero no instala la interfaz grafica para el VS 2015 aun.

Para esto debemos bajar los siguientes software:

01 [Lugar]https://dotnet.microsoft.com/download Mencionado al inicio.

02 [Lugar]https://aka.ms/dotnet-standard-support-vs2015-2.0.0-win-x86

03 [Lugar]https://go.microsoft.com/fwlink/?LinkID=824849

Estos dos ultimos son opcionales (si no los tienes instalados)

04 .Net Framework 7.2 [Lugar](https://go.microsoft.com/fwlink/?LinkId=863261&clcid=0x409)

05 SP 3 para VS 20115 [Lugar](https://go.microsoft.com/fwlink/?LinkId=691129)


## 1) **Instalacion de Microsoft .NET Core SDK 2.2.202**

 ![dotnet image 2.png](https://tydw.files.wordpress.com/2019/04/01.png)

 ![dotnet image 3.png](https://tydw.files.wordpress.com/2019/04/02.png)
 
 ![3.png](https://tydw.files.wordpress.com/2019/04/03.png)

 


 ## 2) **Microsft .NET Core 1.0.0 VS 2015 Tooling Preview 2**

 ![0.png](https://tydw.files.wordpress.com/2019/04/05.png?w=300&h=114.png)

 ![01.png](https://tydw.files.wordpress.com/2019/04/06.png)

 ![02.png](https://tydw.files.wordpress.com/2019/04/07.png)

 ![03.png](https://tydw.files.wordpress.com/2019/04/08.png)

Una vez instalado el .NET CORE prosigue descargar Visual Studio Code y a continuacion explicamos como son los pasos para realizarlo

## Pasos para instalar y configurar Visual Studio Code para C#.

Lo primero que debes hacer es instalar Visual Studio Code. Para ello basta con que entremos a su página de descargas

(https://code.visualstudio.com/) y nos descarguemos e instalemos la versión apropiada para nuestro sistema operativo.

![b1.png](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/DescargarVSC.png)

Desde la página de descargas se pueden descargar las versiones para diferentes sistemas operativos (32 / 64 bits, Windows / GNU/Linux /

Mac). En Windows hay además disponibles versiones System installer, que se instalan en la carpeta de Archivos de programa, y versiones 

User installer, que se instalan en la carpeta de usuario. Desde el verano de 2018, Microsoft recomienda la versión User installer.

Enlaces de descarga para Windows: [Visual Studio Code (64 bits, recomendado)](https://code.visualstudio.com/docs/?dv=win64user) -

[Visual Studio Code (32 bits)](https://code.visualstudio.com/docs/?dv=win32user)

![b3.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-descargar-2.png)

## Instalar Visual Studio Code en Windows
Nota: Las capturas siguientes corresponden a Visual Studio Code 1.27 (User installer) en Windows 10 de 64 bits. Versiones posteriores 

pueden ser ligeramente diferentes.

# 1.-Haga doble clic sobre el instalador de Visual Studio Code para poner en marcha el asistente de instalación.

# 2.-La primera pantalla exige aceptar la licencia de Visual Studio Code para continuar la instalación:

![b4.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-1.png)

# 3.-La segunda pantalla permite elegir el directorio de instalación (por tratarse de la versión User installer, el directorio de instalación está en la carpeta de usuario, no en Archivos de programa):

![b5.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-2.png)

# 4.-La tercera pantalla permite elegir el nombre de la carpeta del menú de inicio:

![b6.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-3.png)

# 5.-La cuarta pantalla permite elegir algunas tareas adicionales tras la instalación. Personalmente, aconsejo marcar las casillas "Agregar la acción ...":

![b7.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-3.png)

# 6.-Finalmente se muestran las opciones elegidas en las pantallas anteriores. Para iniciar la instalación, haga clic en Instalar.

![b8.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-5.png)


# 7.-A continuación, se instalará Visual Studio Code.

![b9.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-6.png)

# 8.-Una vez completada la instalación, se muestra la pantalla final. Si va a utilizar Git con Visual Studio Code, desmarque la casilla "Ejecutar Visual Studio Code", haga clic en Finalizar e instale Git.

![b10.png](https://www.mclibre.org/consultar/informatica/img/vscode/vsc-instalacion-7.png)

## Descargar e instalar C#

Para poder desarrollar todo su potencial, Visual Studio Code utiliza un sistema de extensiones que nos permiten ampliar su

funcionalidad. Estas extensiones se pueden descargar desde el propio entorno o desde el [Extension Marketplace](https://code.visualstudio.com/docs/editor/extension-gallery)  (aunque esto realmente, lo 

que va a hacer es abrir el IDE y llevarnos a la extensión).

Para empezar a preparar nuestro entorno, vamos a utilizar la extensión para el lenguaje [C#](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp).

Para instalar esta extensión, desde la web, basta con que pulsemos sobre Install:

![b11.png](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/BotonInstall.png)

Nos va a pedir como requisito tener instalado Visual Studio Code, y como nosotros ya lo tenemos, en la ventana emergente pulsamos sobre

el botón Abrir Visual Studio Code:

![b12.png](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/AbrirVSC.png)

Esto nos abre Visual Studio Code, y nos muestra directamente la extensión, aquí basta con pulsar sobre el botón Install para que se 

inicie el proceso:

![b13.png](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/BotonInstallVSC.png)

Una vez que termine tenemos que recargar el IDE. Para eso basta con pulsar en el botón de recargar:

![b14.png](https://www.campusmvp.es/recursos/image.axd?picture=/2019/1T/vscode-netcore/reload.png)

Con esto, ya tenemos nuestro entorno de trabajo Visual Studio Code para trabajar con el lenguaje C# y con .NET Core.































