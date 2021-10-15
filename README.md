# Double Inexacto

Los números reales en punto flotante (float, double) no son suficientemente exactos para conceptos como el sueldo, por ejemplo.

En este ejemplo, creamos una clase **Empleado**. Esta clase mantiene dos sueldos: uno, *Sueldo*, que se guarda como un **double** (es una propiedad automática), de hecho; *Sueldo2*, el segundo sueldo, es una propiedad tipo *double* que actúa como frente para un atributo *sueldo*.

En el código de los tests de unidad, veremos que incrementar el sueldo en 100.01€ no funciona correctamente en la propiedad automática, pero sí en la propiedad que funciona como interfaz para el atributo entero *sueldo*.

El propósito de utilizar un entero es evitar las acumulaciones de errores: las operaciones repetidas sobre un variable *double* van acumulando pequeños errores que al final acaban produciendo la pérdida de un céntimo.

En casos extremos, es posible utilizar un entero para los céntimos y otro para los euros (la parte entera).

[IEEE 754: números en punto flotante](https://es.wikipedia.org/wiki/IEEE_754)

[Artículo "What every programmer should know about floating point numbers"](https://docs.oracle.com/cd/E19957-01/806-3568/ncg_goldberg.html)
