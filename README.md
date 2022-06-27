Музика Стефан
ІС-02
11-й варіант

Розробити модель вибору способів сортування та пошуку максимального / мінімального значення масиву числових об'єктів

ОРПЗ .НЕТ ЛР №5

Пояснення до структури проекту.

Я об’єднав при проєктуванні застосунку два патерни – стратегію та ітератора.
Колекцію чисел типу double описує клас DoubleCollection, що реалізує абстрактний клас IterableCollection. Сам ітератор описує абстрактний клас CollectionIterator. Він реалізує клас Iterator. Різні типи сортування описуються класами MergeSort, InsertionSort, BubbleSort, що, в свою чергу, реалізують інтерфейс ISort. AnalyseSort описує посередника між користувачем і власне самим сортуванням, що надає додаткові функції для користувача, такі як: обрахування час, затраченого на сортування, визначення мінімального та максимального елемента.
![Untitled Diagram drawio (1) (2)](https://user-images.githubusercontent.com/76735417/175928707-36836a16-7072-4cb9-8eb4-30a1c09bdd5c.png)
