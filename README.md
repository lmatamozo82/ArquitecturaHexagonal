# Descrici�n de Arquitectura Hexagonal

La Arquitectura Hexagonal, tambien conocida como Ports&Adapters, es una arquitectura de software enmarcada dentro de las conocidas como **Clean Arquitectures**. La implementaci�n de una arquitectura de este tipo se basa en la necesidad de realizar las implementaciones necesarias para que la l�gica de negocio se pueda comunicar con elementos externos sin necesidad de cambios. 

![React+Redux Demo](img/Intro.jpg)

## Objetivo

El objetivo final de la Arquitectura Hexagonal es dotar a la aplicaci�n en la que se implementa de muchas ventajas, tales como:
* Mejor adaptabilidad, ya que no la hace dependiente de ning�n elemento de infraestructura concreto.
* Test m�s f�cil de implementar.
* Abstrae al core de la aplicaci�n de los detalles de implementaci�n.
* El mantenimiento de la aplicaci�n es mucho m�s sencillo.

En el siguiente grafico, vemos con mayor nivel de detalle la separaci�n de conceptos que propone la implementaci�n de arquitectura hexagonal:

![React+Redux Demo](img/Completa.jpg)


La arquitectura hexagonal utiliza la met�fora de los puertos y adaptadores para representar las interacciones entre el interior y el exterior. Para ello, utiliza la siguiente clasificaci�n:
* Puertos de Nivel 1: Se definen en la capa de Dominio. Son interfaces que se crean para exponer los Casos de Uso implementados en la capa de Dominio.
* Puertos de Nivel 2: Se definen en la capa de Dominio. Son interfaces que deben implementar los adaptadores de Nivel 2 para asegurar la correcta comunicaci�n con sistemas externos (BBDD, Mensajeria, Sistema de Ficheros, etc.).
* Adaptadores de Nivel 1: Son las implementaciones de las interfaces de los Puertos de Nivel 1. Se utilizan para la implementaci�n de las comunicaciones con el usuario final, por ejemplo, un controlador de una WebAPI.
* Adaptadores de Nivel 2: Son las implementaciones de las interfaces de los Puertos de Nivel 2. Se utilizan para que el Dominio de la aplicaci�n pueda hacer uso de los sistemas de Infraestructura.


## Implementaci�n de Ejemplo

En el ejemplo de c�digo de este repositorio se ha implementado esta arquitectura de una forma muy b�sica para que sirva como concepto.

![React+Redux Demo](img/UMLBasico.jpg)