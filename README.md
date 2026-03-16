# EjerciciosBuilder-Semana9

# Caso 1: Creación de un Usuario en un Sistema
En una aplicación de software, al momento de registrar un usuario pueden existir muchos datos que conforman su perfil, como nombre, correo electrónico, contraseña, rol dentro del sistema, teléfono, dirección y estado de la cuenta. No todos los registros de usuario necesariamente requieren todos estos datos desde el inicio, por lo que el proceso de construcción del objeto puede volverse complejo si se utilizan constructores tradicionales con muchos parámetros. En este caso, el patrón Builder permite construir el objeto usuario paso a paso, agregando únicamente la información necesaria en cada momento, mejorando la legibilidad del código y facilitando el mantenimiento del sistema.

# Caso 2: Generación de un Reporte en un Sistema Informático
En muchos sistemas es necesario generar reportes que pueden contener diferentes secciones, como título, autor, fecha, tablas de datos, gráficos, conclusiones o comentarios finales. Dependiendo del tipo de reporte, algunas de estas secciones pueden ser opcionales o variar en su contenido. El uso del patrón Builder permite crear el reporte de manera flexible, agregando cada parte de forma gradual durante el proceso de construcción del objeto. De esta manera se evita la creación de constructores complejos y se facilita la generación de distintos tipos de reportes utilizando la misma estructura base.

