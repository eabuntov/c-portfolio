# c-portfolio:

Примеры моих проектов на C#, реализованных мной в 2013 - 2015 гг.


SemiFit - основной и наиболее универсальный проект по нелинейной аппроксимации экспериментальных данных.

Данные для аппроксимации (одна или несколько зависимостей Y(X) в виде массивов) загружаются из текстового файла или из буфера обмена в экземпляр класса FitDataSet, отображаются на графике. Имеется возможность выбора диапазона аппроксимации по оси X.
Функция для аппроксимации может быть составлена из базовых примитивов (решение FitFunctions - прямая, степенная функция, экспонента, функции Гаусса и Лоренца) путем применения алгебраических операций (+, -, *, /).

Достоинством программы по сравнению со стандартными решениями, например пакетом Origin, является гибкость и простота составления модели аппроксимирующей функции из примитивов, а также удобство ручной подгонки исходного состояния модели для последующей автоматической оптимизации.

На следующем этапе используя один из алгоритмов нелинейной аппроксимции (Решение Approximation, алгоритмы Левенберга-Маркара, CG, а также собственный "наивный" алгоритм изменения всех параметров) можно описать данные созданной моделью, указав требую точность и максимальное количество итераций.

Параметры аппроксимации и полученную кривую можно экспортировать в виде таблиц.

PLQuench - более узкое решение для аппроксимации кривых температурного тушения фотолюминесценции.