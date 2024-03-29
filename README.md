# Лабораторная работа №1 по алгоритмам и структурам данных
## Вводные
- Матрица размером N = 2 ^ 13, M = 2 ^ X, X = 1..13  
- ***2*** типа заполнения матрицы (***"FillType"***)
  - 0 - A[i][j] = (N / M * i + j) * 2, target = 2 * N + 1
  - 1 - A[i][j] = (N / M * i * j) * 2, target = 16 * N + 1
- Выполнены 3 типа поиска
  - Лестничный (***"LadderSearch"***)
  - Бинарный (***"BinarySearch"***)
  - Экспоненциальный (***"ExponentialSearch"***)

## Окружение бенчмарка
```
BenchmarkDotNet v0.13.10, Arch Linux
AMD Ryzen 9 5980HX with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.100-rc.2.23502.2
  [Host]     : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.47906), X64 RyuJIT AVX2
```
## Результаты бенчмарка в виде таблицы
| Method                | FillType  |   X    |               Mean |             Error |            StdDev |             Median | Allocated |
|-----------------------|:---------:|:------:|-------------------:|------------------:|------------------:|-------------------:|----------:|
| **LadderSearch**      |   **0**   | **1**  |   **4,276.144 ns** |    **79.6007 ns** |    **74.4586 ns** |   **4,279.363 ns** |     **-** |
| **LadderSearch**      |   **0**   | **2**  |   **6,568.505 ns** |    **36.6728 ns** |    **32.5095 ns** |   **6,560.073 ns** |     **-** |
| **LadderSearch**      |   **0**   | **3**  |   **7,493.771 ns** |   **114.8606 ns** |   **101.8210 ns** |   **7,472.445 ns** |     **-** |
| **LadderSearch**      |   **0**   | **4**  |   **8,201.763 ns** |    **44.1196 ns** |    **36.8419 ns** |   **8,199.045 ns** |     **-** |
| **LadderSearch**      |   **0**   | **5**  |   **8,276.689 ns** |    **25.3735 ns** |    **22.4929 ns** |   **8,268.411 ns** |     **-** |
| **LadderSearch**      |   **0**   | **6**  |   **9,018.737 ns** |    **33.4170 ns** |    **31.2583 ns** |   **9,014.769 ns** |     **-** |
| **LadderSearch**      |   **0**   | **7**  |   **9,550.450 ns** |    **49.2616 ns** |    **43.6691 ns** |   **9,553.458 ns** |     **-** |
| **LadderSearch**      |   **0**   | **8**  |   **8,688.111 ns** |    **27.3351 ns** |    **24.2318 ns** |   **8,686.822 ns** |     **-** |
| **LadderSearch**      |   **0**   | **9**  |   **9,719.340 ns** |    **23.0773 ns** |    **21.5865 ns** |   **9,717.460 ns** |     **-** |
| **LadderSearch**      |   **0**   | **10** |  **10,623.873 ns** |   **202.3660 ns** |   **207.8149 ns** |  **10,499.273 ns** |     **-** |
| **LadderSearch**      |   **0**   | **11** |  **16,921.323 ns** |   **112.1431 ns** |    **93.6445 ns** |  **16,944.971 ns** |     **-** |
| **LadderSearch**      |   **0**   | **12** |  **24,770.726 ns** |   **183.8242 ns** |   **143.5178 ns** |  **24,751.239 ns** |     **-** |
| **LadderSearch**      |   **0**   | **13** |  **44,688.950 ns** |   **892.8737 ns** |   **835.1946 ns** |  **44,256.337 ns** |     **-** |
|                       |           |        |                    |                   |                   |                    |           |
| **LadderSearch**      |   **1**   | **1**  |   **8,435.526 ns** |    **48.2965 ns** |    **42.8136 ns** |   **8,432.161 ns** |     **-** |
| **LadderSearch**      |   **1**   | **2**  |   **8,390.068 ns** |    **30.5839 ns** |    **25.5389 ns** |   **8,389.270 ns** |     **-** |
| **LadderSearch**      |   **1**   | **3**  |   **8,727.407 ns** |    **35.0494 ns** |    **31.0704 ns** |   **8,726.476 ns** |     **-** |
| **LadderSearch**      |   **1**   | **4**  |   **8,962.839 ns** |    **37.3573 ns** |    **34.9440 ns** |   **8,965.929 ns** |     **-** |
| **LadderSearch**      |   **1**   | **5**  |   **8,480.261 ns** |    **35.6809 ns** |    **33.3759 ns** |   **8,485.645 ns** |     **-** |
| **LadderSearch**      |   **1**   | **6**  |   **9,079.187 ns** |    **14.9865 ns** |    **13.2851 ns** |   **9,074.077 ns** |     **-** |
| **LadderSearch**      |   **1**   | **7**  |   **9,375.424 ns** |    **37.4504 ns** |    **33.1988 ns** |   **9,382.281 ns** |     **-** |
| **LadderSearch**      |   **1**   | **8**  |  **10,340.770 ns** |    **43.8161 ns** |    **38.8418 ns** |  **10,342.586 ns** |     **-** |
| **LadderSearch**      |   **1**   | **9**  |  **12,483.891 ns** |   **168.2591 ns** |   **149.1573 ns** |  **12,512.567 ns** |     **-** |
| **LadderSearch**      |   **1**   | **10** |  **16,032.020 ns** |   **260.7283 ns** |   **243.8854 ns** |  **16,125.450 ns** |     **-** |
| **LadderSearch**      |   **1**   | **11** |  **22,969.610 ns** |   **457.6890 ns** |   **685.0473 ns** |  **23,145.818 ns** |     **-** |
| **LadderSearch**      |   **1**   | **12** |  **35,639.313 ns** |   **702.3914 ns** |   **937.6724 ns** |  **36,013.095 ns** |     **-** |
| **LadderSearch**      |   **1**   | **13** |  **59,099.267 ns** | **1,120.4559 ns** | **1,290.3187 ns** |  **59,373.644 ns** |     **-** |
|                       |           |        |                    |                   |                   |                    |           |
| **BinarySearch**      |   **0**   | **1**  |      **26.249 ns** |     **0.5312 ns** |     **0.7091 ns** |      **26.251 ns** |     **-** |
| **BinarySearch**      |   **0**   | **2**  |      **47.070 ns** |     **0.0597 ns** |     **0.0558 ns** |      **47.074 ns** |     **-** |
| **BinarySearch**      |   **0**   | **3**  |      **92.435 ns** |     **0.1865 ns** |     **0.1456 ns** |      **92.411 ns** |     **-** |
| **BinarySearch**      |   **0**   | **4**  |     **194.061 ns** |     **0.6473 ns** |     **0.5738 ns** |     **194.182 ns** |     **-** |
| **BinarySearch**      |   **0**   | **5**  |     **404.295 ns** |     **1.1678 ns** |     **0.9752 ns** |     **404.357 ns** |     **-** |
| **BinarySearch**      |   **0**   | **6**  |     **833.888 ns** |     **3.0694 ns** |     **2.8712 ns** |     **833.412 ns** |     **-** |
| **BinarySearch**      |   **0**   | **7**  |   **1,815.645 ns** |    **10.3068 ns** |     **9.6409 ns** |   **1,816.818 ns** |     **-** |
| **BinarySearch**      |   **0**   | **8**  |   **3,696.759 ns** |     **7.6348 ns** |     **7.1416 ns** |   **3,697.391 ns** |     **-** |
| **BinarySearch**      |   **0**   | **9**  |   **7,261.100 ns** |    **31.0396 ns** |    **25.9195 ns** |   **7,255.448 ns** |     **-** |
| **BinarySearch**      |   **0**   | **10** |  **14,941.778 ns** |    **52.0900 ns** |    **46.1764 ns** |  **14,944.106 ns** |     **-** |
| **BinarySearch**      |   **0**   | **11** | **108,945.076 ns** | **2,115.2841 ns** | **2,263.3303 ns** | **109,389.714 ns** |     **-** |
| **BinarySearch**      |   **0**   | **12** | **310,904.404 ns** | **1,749.9439 ns** | **1,551.2797 ns** | **311,377.316 ns** |     **-** |
| **BinarySearch**      |   **0**   | **13** | **736,010.604 ns** | **3,936.4639 ns** | **3,287.1256 ns** | **735,770.214 ns** |   **1 B** |
|                       |           |        |                    |                   |                   |                    |           |
| **BinarySearch**      |   **1**   | **1**  |      **25.992 ns** |     **0.5470 ns** |     **0.7845 ns** |      **25.743 ns** |     **-** |
| **BinarySearch**      |   **1**   | **2**  |      **48.448 ns** |     **0.4051 ns** |     **0.3790 ns** |      **48.403 ns** |     **-** |
| **BinarySearch**      |   **1**   | **3**  |      **96.320 ns** |     **0.6682 ns** |     **0.6251 ns** |      **96.267 ns** |     **-** |
| **BinarySearch**      |   **1**   | **4**  |     **204.415 ns** |     **0.3054 ns** |     **0.2707 ns** |     **204.389 ns** |     **-** |
| **BinarySearch**      |   **1**   | **5**  |     **399.565 ns** |     **0.8670 ns** |     **0.8110 ns** |     **399.747 ns** |     **-** |
| **BinarySearch**      |   **1**   | **6**  |   **1,013.348 ns** |     **5.5267 ns** |     **5.1697 ns** |   **1,012.705 ns** |     **-** |
| **BinarySearch**      |   **1**   | **7**  |   **1,974.013 ns** |     **9.0339 ns** |     **8.0083 ns** |   **1,972.633 ns** |     **-** |
| **BinarySearch**      |   **1**   | **8**  |   **4,043.035 ns** |     **9.3130 ns** |     **8.2557 ns** |   **4,041.964 ns** |     **-** |
| **BinarySearch**      |   **1**   | **9**  |   **7,670.319 ns** |    **19.3475 ns** |    **16.1560 ns** |   **7,663.952 ns** |     **-** |
| **BinarySearch**      |   **1**   | **10** |  **15,823.482 ns** |   **182.8071 ns** |   **170.9979 ns** |  **15,855.284 ns** |     **-** |
| **BinarySearch**      |   **1**   | **11** |  **32,679.370 ns** |   **218.4291 ns** |   **193.6317 ns** |  **32,696.153 ns** |     **-** |
| **BinarySearch**      |   **1**   | **12** | **180,156.946 ns** | **1,130.6078 ns** | **1,002.2544 ns** | **180,208.268 ns** |     **-** |
| **BinarySearch**      |   **1**   | **13** | **450,914.914 ns** | **1,594.1643 ns** | **1,413.1852 ns** | **451,153.340 ns** |     **-** |
|                       |           |        |                    |                   |                   |                    |           |
| **ExponentialSearch** |   **0**   | **1**  |       **9.478 ns** |     **0.0289 ns** |     **0.0241 ns** |       **9.483 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **2**  |      **11.398 ns** |     **0.0166 ns** |     **0.0147 ns** |      **11.402 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **3**  |      **17.952 ns** |     **0.1038 ns** |     **0.0811 ns** |      **17.924 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **4**  |      **29.138 ns** |     **0.0746 ns** |     **0.0661 ns** |      **29.148 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **5**  |      **53.405 ns** |     **0.5534 ns** |     **0.4905 ns** |      **53.348 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **6**  |     **718.933 ns** |    **16.2197 ns** |    **47.8242 ns** |     **724.369 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **7**  |   **1,498.035 ns** |    **33.8527 ns** |    **99.8155 ns** |   **1,529.641 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **8**  |   **2,905.603 ns** |    **86.6401 ns** |   **255.4603 ns** |   **2,923.974 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **9**  |   **6,009.610 ns** |   **118.4055 ns** |   **281.4031 ns** |   **6,080.731 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **10** |  **11,079.900 ns** |   **220.3434 ns** |   **397.3246 ns** |  **11,213.416 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **11** |  **21,808.645 ns** |   **435.6684 ns** |   **691.0162 ns** |  **21,877.266 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **12** |  **45,182.802 ns** |   **886.3359 ns** | **1,431.2673 ns** |  **45,256.089 ns** |     **-** |
| **ExponentialSearch** |   **0**   | **13** |  **92,178.113 ns** | **1,618.8458 ns** | **1,351.8095 ns** |  **91,700.340 ns** |     **-** |
|                       |           |        |                    |                   |                   |                    |           |
| **ExponentialSearch** |   **1**   | **1**  |       **9.784 ns** |     **0.0417 ns** |     **0.0370 ns** |       **9.785 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **2**  |      **11.943 ns** |     **0.0345 ns** |     **0.0323 ns** |      **11.925 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **3**  |      **18.501 ns** |     **0.1012 ns** |     **0.0845 ns** |      **18.474 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **4**  |      **30.149 ns** |     **0.0796 ns** |     **0.0745 ns** |      **30.175 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **5**  |      **53.555 ns** |     **1.0841 ns** |     **2.1144 ns** |      **52.748 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **6**  |     **787.410 ns** |    **15.7835 ns** |    **35.9470 ns** |     **794.131 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **7**  |   **1,391.648 ns** |    **27.7470 ns** |    **62.0602 ns** |   **1,399.175 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **8**  |   **3,242.236 ns** |    **64.7799 ns** |   **115.1462 ns** |   **3,271.486 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **9**  |   **6,302.425 ns** |   **126.0188 ns** |   **248.7488 ns** |   **6,331.926 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **10** |  **12,459.095 ns** |   **245.4635 ns** |   **416.8156 ns** |  **12,531.328 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **11** |  **25,329.182 ns** |   **401.3728 ns** |   **375.4443 ns** |  **25,356.859 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **12** |  **49,895.819 ns** |   **994.5625 ns** | **2,476.8058 ns** |  **50,302.644 ns** |     **-** |
| **ExponentialSearch** |   **1**   | **13** |  **90,448.470 ns** | **1,744.9978 ns** | **1,791.9843 ns** |  **90,968.673 ns** |     **-** |

## Результаты в виде графиков
![График при первом заполнении](Graphs/FillType0.png)
![Логарифмический график при первом заполнении](Graphs/FillType0Log.png)
![График при втором заполнении](Graphs/FillType1.png)
![Логарифмический график при втором заполнении](Graphs/FillType1Log.png)
![График экспоненциального поиска при разных заполнениях](Graphs/ExponentialEveryFillType.png)
![Сравнения графика экспоненциального поиска при разных заполнениях](Graphs/ExponentialEveryFillTypeComparison.png)

## Выводы
1. Бинарный поиск является самым медленным из всех представленных, что сопоставляется с оценкой сложности O(m*log(n)).
   Несмотря на это, на маленьких данных он показывает лучший результат, чем поиск лестницей. Стоит отметить, что при
   x < 9 результаты бин. поиска при 1 и 2 заполнении похожи (результаты отличаются < 10%), однако при x >= 10 на 2 
   заполнении алгоритм выполняется заметно дольше.
2. Лестничный поиск показал самые стабильные результаты. Его сложность O(n + m). Пусть при малых данных (при x < 10) 
   он оказался самым неэффетивным, медленный (линейный) рост позволил ему оказаться самым быстрым при больших данных. 
   Результаты подтверждаются при обоих вариантах заполнения матрицы, однако важно заметить, что при втором заполнении 
   время выполнения лестничного поиска значительно выросло.
3. Экспоненциальный поиск оказался самым эффективным при x < 10. Это связано с его сложностью O(M(logN - logM + 1)), 
   однако он уступил лестничному при больших данных. Время выполнения не зависит от типа заполнения.
4. При x = 10 все алгоритмы демонстрируют примерно одинаковое время исполнения.
5. В целях максимальной производительности стоит использовать экспоненциальный поиск при x <= 10, а при x > 10 - 
   лестничный.