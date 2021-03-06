## Структурни шаблони

### Адаптер

Адаптер шаблона преобразува интерфейса на даден клас в такъв, който клиента очаква. Този шаблон позволява на два класа да си комуникират, при условие, че преди това не са имали възможност, поради несъвместимост на интерфейсите си. 
Срещат се имплементации на класове, които са създадени с цел да се преизползват, но поради несъвместимост на интерфейса си с изискванията на съответното приложение, идеята с която са създадени е неприложима. 
Този вид шаблон е приложим в следните случаи:

- необходимо е използването на даден клас, но интерфейса на този клас не съвпада с този, които е необходим за конкретната имплементация
- при създаването на преизползваем клас, който да комуникира с непредвидени в реализацията на кода класове
- (само за обектен адаптер) необходимо е да се използват няколко съществуващи класа, но е непрактично да се адаптира всеки един интерфейс чрез субклас за всеки един. Обектния адаптер може да адаптира интерфейса на даден родителски клас.   

Сходни шаблони:

- Мост 
- Декоратор
- Прокси

### Мост

Използването на този шаблон води до разделянето на абстракция от имплементация. Когато абстракцията може да има една от няколко възможни имплементации, обичайния подход е да се използва наследяване. Абстрактен клас дефинира интерфейса на абстракцията и няколко подкласа я имплементират по различни начини. Този подход обаче не винаги е подходящ, тъй като наследяването свързва перманентно имплементация с абстракция, което затруднява модифицирането, разширяването и преизползването на абстракции и имплементации независими една спрямо друга.

Използването на шаблона е подходящо в следните случаи:
 
- цели се разделяне на абстракция от имплементация. Този вариант е приложим когато имплементацията трябва да се избере или смени run-time
- и абстракцията и имплементацията и трябва да имат възможност за разширяване от подкласове
- промените в имплементацията на абстракцията не трябва да повлияват на клиента на кода, т.е. кода на клиента не трябва да се прекомпилира 


Сходни шаблони:

- Abstract factory 
- Адаптер

### Фасада

Този шаблон осигурява унифициран интерфейс на съвкупност от интерфейси в една система. Фасада дефинира интерфейс на по-видоко ниво, което допринася за по-лесното използване на системата. 
Разделянето на една система на подсистеми помага за намаляване на сложността на кода. В болшинството от случаите се цели да се минимизира комуникацията и зависимостите между системите. Един от начините това да се постигне е чрез използването на обект "фасада", който осигурява единствен, опростен интерфейс за общите модули в една система. 
Прилагането на шаблона е удачно в следните случаи:

- необходимо е да се предостави опростен интерфейс за комуникация със сложна система. Всяка една система, търпейки развитие става по-сложна с времето. Болшинството от прилаганите шаблони създават повече и по-малки класове. Това прави системата лесно преизползваема и лесно пригодима към нуждите на клиента, но в същото време става по-сложна за клиенти, които нямат нужда от специфични решения. Фасадата осигурява опростен изглед на една система, който е достатъчен за ползвателите на системата. Единствено клиенти, които имат специфични нужди ще е необходимо да "виждат" отвъд фасадата.
- при съществуването на множество зависимости между клиентите и класовете имплементиращи абстракцията. Използването на фасада разделя системата от клиентите и другите системи, като по този начин осигурява независимост на системата.
- при необходимост от изграздане на йерархични слоеве на системата. Използвайки фасада може да се дефинира входна точка за всеки един от слоевете. Ако слоевете зависят един от друг твърде много може да се използва фасада, за да се намалят тези зависимости и комуникацията да се осъществява единствено през собствените фасади.

Сходни шаблони:

- Abstract factory 
- Mediator