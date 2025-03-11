# Cáculo de Figuras Geométricas

Proyecto Académico aplicado Herencia y Polimorfismo mediante C# en formularios Web.

**1. Herencia:** Es un mecanismo en la programación orientada a objetos que permite que una clase (subclase) adquiera los atributos y métodos de otra clase (superclase). Esto facilita la reutilización del código y la jerarquía de clases.
```csharp
// Biblioteca: libClasif3D 
// Clase: clsRedondo.cs
// En este ejemplo, clsRedondo hereda de clsFigura3D, adquiriendo sus atributos y métodos.

public abstract class clsRedondo : clsFigura3D
{
    protected float fltRadio;
    
    public float Radio
    {
        set { fltRadio = value; }
    }
}

```
**2. Polimorfismo:** El polimorfismo permite que una misma operación se ejecute de diferentes maneras según la clase que la implemente.
```csharp
// Biblioteca: libFiguras3D
// Clase: clsEsfera.cs
// Aquí, hallarArea() y hallarVolumen() son métodos sobrescritos (override) que implementan cálculos específicos para una esfera.

public override bool hallarArea()
{
    fltArea = 4 * (float)Math.PI * fltRadio * fltRadio;
    return true;
}

public override bool hallarVolumen()
{
    fltVolumen = (4 / 3) * (float)Math.PI * (fltRadio * fltRadio * fltRadio);
    return true;
}

```
**3. Diferencia entre polimorfismo y sobrecarga en una clase:**

**Polimorfismo:** Se logra mediante herencia y permite redefinir métodos en las clases derivadas.

**Sobrecarga:** Permite definir múltiples métodos con el mismo nombre pero con diferentes parámetros en la misma clase.
```csharp
// Biblioteca: libFiguras3D
// Clase: clsCubo.cs
// Constructor con sobrecarga. (Este ejemplo no se encuentra aplicado)

public clsCubo() { fltLadoA = 0; fltArea = 0; fltVolumen = 0; strError = ""; }

public clsCubo(float lado)
{
    fltLadoA = lado;
    fltArea = 0;
    fltVolumen = 0;
    strError = "";
}

```
**4. ¿Qué es una clase abstracta y por qué usarla?**

Una clase abstracta es una clase que no puede instanciarse y se usa como base para otras clases. Se utiliza para definir estructuras generales que deben ser implementadas en las clases derivadas.
```csharp
// Biblioteca: libFigura3D
// Clase: clsFigura3D.cs

public abstract class clsFigura3D
{
    protected float fltArea, fltVolumen;
    protected string strError;

    public abstract bool hallarArea();
    public abstract bool hallarVolumen();
}

```

**5. ¿Cuáles son los componentes básicos de una clase abstracta?**

**A. Atributos protegidos (protected):** Para ser accesibles desde clases derivadas.

**B. Propiedades:** Generalmente de solo lectura para exponer datos.

**C. Métodos abstractos (abstract):** Sin implementación, deben ser redefinidos en las clases derivadas.
```csharp
// Biblioteca: libFigura3D
// Clase: clsFigura3D.cs

protected float fltArea, fltVolumen;
protected string strError;

public abstract bool hallarArea();
public abstract bool hallarVolumen();

```
**6. Requisitos para construir un atributo, propiedad o método en una clase base o derivada:**

**A. Atributos:** Generalmente protected en la base para que las derivadas puedan acceder.

**B. Propiedades:** Deben controlar la asignación de valores con validaciones si es necesario.

**C. Métodos:** Si es abstracto en la base, debe ser override en la derivada.
```csharp
// Biblioteca: libClasif3D
// Clase: clsPoliedro.cs

protected float fltLadoA;  // Atributo protegido

public float Lado_a  // Propiedad
{
    set { fltLadoA = value; }
}

```
**7. ¿Qué determina en una clase base los términos abstract y protected?**

**A. abstract:** Indica que un método debe ser implementado en clases derivadas.

**B. protected:** Permite que un atributo o método sea accesible solo por clases derivadas.
```csharp
// Biblioteca: libFigura3D
// Clase: clsFigura3D.cs

protected float fltArea, fltVolumen; // Atributos accesibles en derivadas
public abstract bool hallarArea();   // Método obligatorio en derivadas

```
**8. Override en una clase derivada:** Se usa para redefinir un método abstracto o virtual de una clase base en una derivada.
```csharp
// Biblioteca: libFiguras3D
// Clase: clsEsfera.cs

public override bool hallarArea()
{
    fltArea = 4 * (float)Math.PI * fltRadio * fltRadio;
    return true;
}

```
**10. ¿Qué consideraciones se deben tener en cuenta con los constructores cuando hay derivación de clases?**

**A.** El constructor de la clase base no se hereda automáticamente.

**B.** Si la clase base tiene un constructor con parámetros, la clase derivada debe llamarlo explícitamente con base().

**C.** Se pueden definir sobrecargas para inicializar atributos de diferentes maneras.
```csharp
// Biblioteca: libFiguras3D
// Clase: clsPrismaRect.cs
// Ejemplo no aplicado en el proyecto.

public clsPrismaRect() : base() // Llamando al constructor de la clase base
{
    fltLadoA = 0;
    fltLadoB = 0;
    fltAltura = 0;
}

```
## Detalles

**Versión:** .NET Framework 4.7.2

**Bootstrap 5**

## Frontend
![form](https://i.ibb.co/N6hsDkDS/Captura-de-pantalla-2025-03-10-211830.png)

![form](https://i.ibb.co/0jxZ4nqY/imagen2.png)

![form](https://i.ibb.co/twMm6DYG/imagen3.png)