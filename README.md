Итоговая практическая работа по программе "Разработчик".

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [] 


Решение задачи.

Для формирования исходного массива строк используется ввод с клаватуры элементов. Количество элементов предварительно запрашивается программой.
В качестве переменной, определяющей условие формирования конечного массива, используется переменная maxLength, равная трем.
Процесс формирования массива строк с элементами из трех и менее символов происходит посредством проверки исходного массива на наличие элементов, удовлетворяющих данному условию, формирования нового массива из этих элементов, и вывод на печать нового массива.

Для реализации данного процесса применяются следующие методы:

1. InputNumbers - метод ввода исходных данных.
2. CheckArray - метод перебора и подсчета элементов исходного массива, удовлетворяющих условию, что элемент должен состоять из трех и менее символов.
3. FillNewArray - метод заполнения нового массива элементами, удовлетворяющими условию, что элемент должен состоять из трех и менее символов.
4. PrintArray - метод вывода конечного массива с элементами из трех и менее символов.