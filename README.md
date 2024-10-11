# .NET Lab4
Lab4 | Design Patterns (поведінкові) | Strategy + Iterator

Stefan Muzyka
IS-02
Variant 11

## Task:
Develop a model for selecting sorting methods and finding the maximum/minimum value in an array of numerical objects.

ОРПЗ .НЕТ ЛР №5

## Explanation of the Project Structure:
In the design of the application, I combined two design patterns – Strategy and Iterator.

- The collection of double numbers is described by the DoubleCollection class, which implements the abstract class IterableCollection.
- The iterator itself is described by the abstract class CollectionIterator, which implements the Iterator class.
- Different sorting types are described by classes such as MergeSort, InsertionSort, and BubbleSort, which, in turn, implement the ISort interface.
- AnalyseSort acts as a mediator between the user and the actual sorting process, providing additional functions for the user, such as calculating the time spent on sorting and determining the minimum and maximum elements.

## Class diagram using Strategy + Iterator patterns

![Untitled Diagram drawio (1) (2)](https://user-images.githubusercontent.com/76735417/175928707-36836a16-7072-4cb9-8eb4-30a1c09bdd5c.png)
