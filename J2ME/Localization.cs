using System;

namespace PlaymanExtremeRunning.J2ME
{
    public static class Localization
    {
        public static readonly string[] LanguageNames =
        {
            "English",
            "Русский",
            "Deutsch",
            "Français",
            "Español",
            "Italiano"
        };

        private static string[] _englishBase;

        public static void CaptureEnglishBase(string[] field145)
        {
            if (_englishBase != null || field145 == null || field145[0] == null)
                return;
            _englishBase = new string[200];
            Array.Copy(field145, _englishBase, 200);
        }

        public static string GetModeOptionLine(int lang, bool remaster)
        {
            return lang switch
            {
                1 => "Режим : " + (remaster ? "Ремастер" : "Оригинал"),
                2 => "Modus : " + (remaster ? "Remaster" : "Original"),
                3 => "Mode : " + (remaster ? "Remaster" : "Original"),
                4 => "Modo : " + (remaster ? "Remaster" : "Original"),
                5 => "Modalita : " + (remaster ? "Remaster" : "Originale"),
                _ => "Mode : " + (remaster ? "Remaster" : "Original")
            };
        }

        public static string GetScreenOptionLine(int lang, int windowMode)
        {
            // windowMode: 0 = Windowed, 1 = Borderless, 2 = Fullscreen
            return lang switch
            {
                1 => "Экран : " + (windowMode == 2 ? "Во весь экран" : (windowMode == 1 ? "Без рамок" : "В окне")),
                2 => "Bildschirm : " + (windowMode == 2 ? "Vollbild" : (windowMode == 1 ? "Rahmenlos" : "Fenster")),
                3 => "Ecran : " + (windowMode == 2 ? "Plein ecran" : (windowMode == 1 ? "Sans bordure" : "Fenetre")),
                4 => "Pantalla : " + (windowMode == 2 ? "Pantalla completa" : (windowMode == 1 ? "Sin bordes" : "Ventana")),
                5 => "Schermo : " + (windowMode == 2 ? "Schermo intero" : (windowMode == 1 ? "Senza bordi" : "Finestra")),
                _ => "Screen : " + (windowMode == 2 ? "Fullscreen" : (windowMode == 1 ? "Borderless" : "Windowed"))
            };
        }

        public static string GetLanguageOptionLine(int lang)
        {
            int idx = Math.Clamp(lang, 0, LanguageNames.Length - 1);
            string label = lang switch
            {
                1 => "Язык : ",
                2 => "Sprache : ",
                3 => "Langue : ",
                4 => "Idioma : ",
                5 => "Lingua : ",
                _ => "Language : "
            };
            return label + LanguageNames[idx];
        }

        public static string GetF1OverlayBarText(int lang)
        {
            return lang switch
            {
                1 => "F1: Скрыть подсказки  |  F2: Режим (Ремастер / Оригинал)  |  F11: Открыть все уровни  |  F12: Полный сброс",
                2 => "F1: Hilfe ausblenden  |  F2: Modus (Remaster / Original)  |  F11: Alle Level freischalten  |  F12: Reset",
                3 => "F1: Masquer l'aide  |  F2: Mode (Remaster / Original)  |  F11: Debloquer tous les niveaux  |  F12: Reset",
                4 => "F1: Ocultar ayuda  |  F2: Modo (Remaster / Original)  |  F11: Desbloquear todos los niveles  |  F12: Reset",
                5 => "F1: Nascondi aiuto  |  F2: Modalita (Remaster / Originale)  |  F11: Sblocca tutti i livelli  |  F12: Reset",
                _ => "F1: Hide Help  |  F2: Mode (Remaster / Original)  |  F11: Unlock All Levels  |  F12: Full Reset"
            };
        }

        public static void ApplyLanguage(string[] s, int lang)
        {
            if (s == null || s.Length < 200) return;
            CaptureEnglishBase(s);
            if (_englishBase != null)
                Array.Copy(_englishBase, s, 200);

            const string driveUrl = "https://drive.google.com/drive/folders/1JbLXRdw-JprXtq6e3pHWrWzeBizVyfZz";

            // Always apply English enhancements for Controls (84), About (135), and Prize (156)
            // IMPORTANT: Use \u0014, \u0015, \u001b, \u0013 (4-digit hex) so C# never merges following hex digits!
            s[84] =
                "\u0014Up\u0015\u001b23:\u00132:W, Up, Space, A/Y\u001b3:\u00131:\n" +
                "\u0014Down\u0015\u001b23:\u00132:S, Down, Pad B\u001b3:\u00131:\n" +
                "\u0014Left\u0015\u001b23:\u00132:A, Left, Stick\u001b3:\u00131:\n" +
                "\u0014Right\u0015\u001b23:\u00132:D, Right, Stick\u001b3:\u00131:\n" +
                "\u0014Select\u0015\u001b23:\u00132:Enter, Space, A\u001b3:\u00131:\n" +
                "\u0014Pause\u0015\u001b23:\u00132:Esc, Start\u001b3:\u00131:\n" +
                "\u0014Help Bar\u0015\u001b23:\u00132:F1\u001b3:\u00131:\n" +
                "\u0014Mode\u0015\u001b23:\u00132:F2, Select\u001b3:\u00131:\n" +
                "\u0014Unlock Levels\u0015\u001b23:\u00132:F11\u001b3:\u00131:\n" +
                "\u0014Full Reset\u0015\u001b23:\u00132:F12";

            s[135] =
                "\u001b21:Playman Extreme Running\u001b3:\n" +
                "Version 1.0.4 (unofficial remaster by FLEKSO)\n\n" +
                "© 2007 RealNetworks, Inc. All rights reserved.\n\n" +
                "Published by RealNetworks, Inc.\n" +
                "Developed by Mr.Goodliving Ltd.\n\n" +
                "This game is protected by copyright and is proprietary to RealNetworks, Inc. Any copying, modification, distribution or public display of this game without the written consent of RealNetworks, Inc. is strictly prohibited.\n";

            s[156] =
                "Collect your prize from: \n\n" +
                "www.playmansports.com/award/Wxxy9 (site does not work)\n\n" +
                "Prize material and more: " + driveUrl + " (author The Vault (youtube))";

            if (lang == 1)
            {
                ApplyRussian(s, driveUrl);
            }
            else if (lang == 2)
            {
                ApplyGerman(s, driveUrl);
            }
            else if (lang == 3)
            {
                ApplyFrench(s, driveUrl);
            }
            else if (lang == 4)
            {
                ApplySpanish(s, driveUrl);
            }
            else if (lang == 5)
            {
                ApplyItalian(s, driveUrl);
            }
        }

        private static void ApplyRussian(string[] s, string driveUrl)
        {
            s[0] = "Звуки";
            s[1] = "Да";
            s[2] = "Нет";
            s[3] = "%1?";
            s[4] = "Выбор";
            s[5] = "Назад";
            s[6] = "Сменить";
            s[7] = "Выход";
            s[8] = "Продолжить";
            s[9] = "Вкл";
            s[10] = "Выкл";
            s[11] = "Настройки";
            s[12] = "Сброс рекордов";
            s[13] = "Сброс игры";
            s[14] = "Продолжить игру";
            s[15] = "Закончить игру";
            s[16] = "Пауза";
            s[17] = "Продолжить";
            s[18] = "Загрузка";
            s[19] = "Звук";
            s[20] = "Один игрок";
            s[21] = "Мультиплеер";
            s[22] = "Ещё раз";
            s[23] = "Ещё";
            s[24] = "ОК";
            s[25] = "Начать игру";
            s[26] = "Стереть";
            s[27] = "Сдаться";
            s[28] = "Введите имя";
            s[29] = "Игрок";
            s[30] = "Игрок %1";
            s[31] = "Бег";
            s[32] = "Прыжок";
            s[33] = "Приземление";
            s[34] = "По лестнице вверх";
            s[35] = "Спуск вниз";
            s[36] = "Прыжок от стены";
            s[37] = "Бег по стене";
            s[38] = "Залезть на край";
            s[39] = "Кувырок";
            s[40] = "Сальто вперёд";
            s[41] = "Сальто назад";
            s[42] = "Прыжок тигра";
            s[43] = "Сальто от стены";
            s[44] = "Опорный прыжок";
            s[45] = "Рывок через край";
            s[46] = "Опорный с сальто";
            s[47] = "Прыжок паука";
            s[48] = "Скольжение по шесту";
            s[49] = "Прыжок с шеста";
            s[50] = "Разворот на шесте";
            s[51] = "\u0016\u00191:\n\u00130:\u001b2:Персонаж бежит автоматически. Вовремя выполняйте трюки, чтобы сохранять скорость.";
            s[52] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВВЕРХ\u001b2: во время бега.";
            s[53] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВНИЗ\u001b2: в воздухе перед самой землёй при прыжках с большой высоты.";
            s[54] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВВЕРХ\u001b2: на лестнице, чтобы полезть вверх.";
            s[55] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВНИЗ\u001b2: на лестнице, чтобы скользить вниз.";
            s[56] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните на стену и нажмите \u001b23:НАЗАД\u001b2: перед касанием стены.";
            s[57] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните к стене и нажмите \u001b23:ВВЕРХ\u001b2: 1-3 раза перед касанием стены.";
            s[58] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВВЕРХ\u001b2:, когда висите на краю.";
            s[59] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВНИЗ\u001b2: во время бега, чтобы проскочить под низким препятствием.";
            s[60] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните и нажмите \u001b23:ВПЕРЁД\u001b2: в воздухе для сальто вперёд.";
            s[61] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните и нажмите \u001b23:НАЗАД\u001b2: в воздухе для сальто назад.";
            s[62] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВПЕРЁД\u001b2: во время бега для длинного прыжка тигра.";
            s[63] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВПЕРЁД\u001b2: прямо перед стеной в прыжке.";
            s[64] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните и нажмите \u001b23:ВВЕРХ\u001b2: над низким препятствием.";
            s[65] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВНИЗ\u001b2: прямо перед краем крыши для ускорения.";
            s[66] = "\u0016\u00191:\n\u00130:\u001b2:Сделайте прыжок тигра перед препятствием и нажмите \u001b23:ВНИЗ\u001b2: над ним.";
            s[67] = "\u0016\u00191:\n\u00130:\u001b2:Сделайте прыжок тигра перед препятствием и нажмите \u001b23:ВВЕРХ\u001b2: над ним.";
            s[68] = "\u0016\u00191:\n\u00130:\u001b2:Нажмите \u001b23:ВНИЗ\u001b2: перед шестом в воздухе, чтобы схватиться за него.";
            s[69] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните и нажмите \u001b23:ВПЕРЁД\u001b2: перед шестом или во время скольжения.";
            s[70] = "\u0016\u00191:\n\u00130:\u001b2:Прыгните и нажмите \u001b23:НАЗАД\u001b2: перед шестом для смены направления.";
            s[79] = "Общее";
            s[80] = "Встречайте Плеймена, его сестру Блэр и 8 соперников в соревнованиях по паркуру!\n\nПобеждайте соперников по времени, очкам и стилю на крышах города.\n\nВ одиночной игре можно играть за \u001b23:\u00132:Плеймена\u001b3:\u00131: или \u001b23:\u00132:Блэр\u001b3:\u00131:.\n\nВыполняйте серии трюков без падений, чтобы копить шкалу \u001b23:\u00132:FLOW\u001b3:\u00131: и получать больше очков.\n\nВсе трюки описаны в разделе «Трюки».";
            s[81] = "Режимы игры";
            s[82] = "\u001b24:\u00132:Вызов\n\n\u001b3:\u00131:Соперники обучают вас новым трюкам, а затем соревнуются с вами!\n\n\u001b24:\u00132:Спринт\n\n\u001b3:\u00131:Пройдите маршрут через все флажки быстрее соперника.\n\n\u001b24:\u00132:Охота за флагами\n\n\u001b3:\u00131:Найдите 5 спрятанных флагов за отведённое время в любом порядке.\n\n\u001b24:\u00132:Очки FLOW\n\n\u001b3:\u00131:Выполняйте как можно больше трюков по пути к финишу и поддерживайте высокий множитель FLOW!";
            s[83] = "Управление";
            s[84] =
                "\u0014Вверх\u0015\u001b23:\u00132:W, Вверх, Пробел\u001b3:\u00131:\n" +
                "\u0014Вниз\u0015\u001b23:\u00132:S, Вниз, Pad B\u001b3:\u00131:\n" +
                "\u0014Влево\u0015\u001b23:\u00132:A, Влево, Стик\u001b3:\u00131:\n" +
                "\u0014Вправо\u0015\u001b23:\u00132:D, Вправо, Стик\u001b3:\u00131:\n" +
                "\u0014Выбор\u0015\u001b23:\u00132:Enter, Пробел, A\u001b3:\u00131:\n" +
                "\u0014Пауза\u0015\u001b23:\u00132:Esc, Start\u001b3:\u00131:\n" +
                "\u0014Подсказки\u0015\u001b23:\u00132:F1\u001b3:\u00131:\n" +
                "\u0014Режим\u0015\u001b23:\u00132:F2, Select\u001b3:\u00131:\n" +
                "\u0014Все уровни\u0015\u001b23:\u00132:F11\u001b3:\u00131:\n" +
                "\u0014Сброс\u0015\u001b23:\u00132:F12";
            s[85] = "Трюки";
            s[86] = "Соперники научат вас новым трюкам. Освойте их и победите соперников!";
            s[87] = "Пройдите маршрут через чекпоинты и придите к финишу раньше соперника.";
            s[88] = "Соберите 5 флагов за отведённое время в любом порядке.";
            s[89] = "Набирайте максимум очков за трюки! Поддерживайте шкалу FLOW и не спотыкайтесь!";
            s[90] = "Выбор уровня";
            s[91] = "Выбор миссии";
            s[92] = "Милл Брук";
            s[93] = "Норт Хилл";
            s[94] = "Мэйн Стрит";
            s[95] = "Ист Энд";
            s[96] = "Джунипер Пойнт";
            s[97] = "Оук Вэлли";
            s[98] = "Грасс Бэй";
            s[99] = "Сэнд Кейп";
            s[100] = "Центральный парк";
            s[101] = "Бёрд Бэй";
            s[102] = "Вест Харбор";
            s[103] = "Пайн Айленд";
            s[104] = "Отличное место для изучения основ! Спайк живёт на крышах и всегда готов дать совет.";
            s[105] = "Утренние крыши пригорода отлично подходят для закрепления новых навыков.";
            s[106] = "Район больницы — территория Трикс. Она отлично лазает по стенам.";
            s[107] = "Мэйн Стрит — территория Дарта. Здесь важна точность каждого прыжка.";
            s[108] = "Крыши и двор старого музея 1960-х годов отлично подходят для сложных прыжков.";
            s[109] = "Территория Вайпер — мастера преодоления низких препятствий.";
            s[110] = "Территория Ниндзя с видом на восток. «Я просто пришла потусоваться».";
            s[111] = "Песчаный замок — идеальное место для настоящего экстрима.";
            s[112] = "Низкие крыши студийного комплекса у Центрального парка принадлежат Биг Ди.";
            s[113] = "Ночные склады в порту — территория Чили, чемпионки по капоэйре.";
            s[114] = "Гавань опасна ночью. У Чили здесь свои секретные маршруты.";
            s[115] = "Финальное испытание! Осталось победить Тунга — лучшего мастера паркура.";
            s[116] = "Спринт";
            s[117] = "Флаги";
            s[118] = "Очки FLOW";
            s[119] = "Вызов";
            s[120] = "Разминка 1";
            s[121] = "Разминка 2";
            s[122] = "\u001b3:\u00131:Изучите базовое управление.";
            s[123] = "\u001b3:\u00131:Научитесь плавно двигаться и использовать окружение.";
            s[125] = "Рекорд:";
            s[126] = "Плеймен";
            s[127] = "Блэр";
            s[128] = "Плеймен — суперзвезда спорта. Помимо пляжного волейбола, футбола и атлетики, он покоряет экстрим-бег!";
            s[129] = "Сестра Плеймена. Именно она познакомила брата с паркуром и всегда готова к действию!";
            s[130] = "Выбор игрока";
            s[131] = "\u0016 \u001b2:\u00132: Рекорд: %1 очк. \n %6 \u001940: \u001b%8\u00131: %2 \n \u001b2:\u00132: %5 %3 \n \u0016 %7 \u001940: \u001b%9\u00131: %4";
            s[132] = "Пройдите ещё миссий (%1), чтобы открыть этот уровень.";
            s[133] = "Включить звук";
            s[134] = "Пропустить";
            s[135] =
                "\u001b21:Playman Extreme Running\u001b3:\n" +
                "Версия 1.0.4 (неофициальный ремастер от FLEKSO)\n\n" +
                "© 2007 RealNetworks, Inc. Все права защищены.\n\n" +
                "Издатель: RealNetworks, Inc.\n" +
                "Разработчик: Mr.Goodliving Ltd.\n\n" +
                "Эта игра защищена авторским правом и принадлежит RealNetworks, Inc.\n";
            s[138] = "Старт";
            s[139] = "Рекорды";
            s[140] = "Об игре";
            s[141] = "Помощь";
            s[142] = "Главное меню";
            s[143] = "Выход из игры";
            s[144] = "Играть";
            s[145] = "Далее";
            s[146] = "Игроков: %1";
            s[147] = "Результаты";
            s[148] = "Время";
            s[149] = "Очки";
            s[150] = "Рейтинг";
            s[153] = "Дисквалифицирован";
            s[154] = "Приз";
            s[155] = "Закрыто. Пройдите все миссии на всех уровнях, чтобы получить приз.";
            s[156] =
                "Заберите свой приз на: \n\n" +
                "www.playmansports.com/award/Wxxy9 (сайт не работает)\n\n" +
                "Материал из приза и прочее: " + driveUrl + " (автор The Vault (youtube))";
            s[157] = "Поздравляем!";
            s[158] = "Открыт новый уровень!";
            s[159] = "Уровень %1 открыт!";
            s[160] = "\u0016%1\nПриготовьтесь!\n\nПобейте \u001b23:ВРЕМЯ\u001b2: и \u001b23:СЧЁТ\u001b2: соперников!";
            s[161] = "\u0016%1\n\nСчёт: %2\nВремя: %3";
            s[162] = "\u0016%1\nВремя вышло!\nДисквалификация!";
            s[163] = "\u001b2:Совет: нажмите \u001b23:НАЗАД\u001b2: перед стеной, чтобы быстрее развернуться и получить очки.";
            s[164] = "\u001b2:Совет: для мягкого \u001b23:ПРИЗЕМЛЕНИЯ\u001b2: нажмите \u001b23:ВНИЗ\u001b2: перед землёй.";
            s[165] = "\u001b2:Освоим управление! Для трюков используйте \u001b23:вверх\u001b2:, \u001b23:влево\u001b2:, \u001b23:вправо\u001b2: и \u001b23:вниз\u001b2:. Бег автоматический.";
            s[166] = "\u001b2:Когда освоитесь с управлением, возьмите флаг и вернитесь ко мне.";
            s[167] = "\u001b2:Ограничения по времени нет, тренируйтесь сколько угодно.";
            s[168] = "\u001b2:Отлично! Вы готовы к следующему испытанию!";
            s[169] = "\u001b2:Следуйте по стрелкам и нажимайте соответствующие кнопки для выполнения трюков.";
            s[170] = "\u001b2:Возьмите флаг и вернитесь ко мне.";
            s[171] = "\u001b2:Не страшно, если пропустите стрелку. Главное — сохранять темп!";
            s[172] = "\u001b2:Супер! Теперь вы готовы к остальным режимам игры.";
            s[173] = "\u001b2:P.S. Все движения можно посмотреть в меню «Трюки».";
            s[174] = "Неудача!";
            s[175] = "Пройдено!";
            s[176] = "Пройдено!";
            s[177] = "Время вышло!";
            s[178] = "\u001b2:Соберите все 5 флагов и прибегите к финишу раньше меня!";
            s[179] = "\u001b2:Найдите 5 флагов до конца времени в любом порядке!";
            s[180] = "\u001b2:Цель: \u001b23:%1\u001b2: очк.\n\nПоддерживайте \u001b23:FLOW\u001b2:, чтобы набрать больше очков до финиша.";
            s[181] = "\u001b2:Освойте прыжки от стен, возьмите флаг и вернитесь к финишу!";
            s[182] = "\u001b2:Освойте трюк \u001b23:САЛЬТО ОТ СТЕНЫ\u001b2:. Он даёт много очков!";
            s[183] = "\u001b2:Преодолевайте малые препятствия трюками \u001b23:ОПОРНЫЙ ПРЫЖОК\u001b2:, \u001b23:ПАУК\u001b2: и \u001b23:ОПОРНЫЙ С САЛЬТО\u001b2:.";
            s[184] = "\u001b2:Используйте шесты: сделайте \u001b23:ПРЫЖОК С ШЕСТА\u001b2:, \u001b23:СКОЛЬЖЕНИЕ\u001b2: и \u001b23:РАЗВОРОТ НА ШЕСТЕ\u001b2:.";
            s[185] = "\u001b2:Наберите \u001b23:2000\u001b2: очков за 20 секунд.";
            s[186] = "\u001b2:Наберите \u001b23:3200\u001b2: очков за 20 секунд.";
            s[187] = "\u001b2:Наберите \u001b23:5000\u001b2: очков за 20 секунд.";
            s[188] = "\u001915:\u0016\u001c13:\n\u001b6:%1\u0014\u001b5:Ваше время: \u0015\u001b7:\u00131:%2\u0014\u001b5:\u00132:Счёт: \u0015\u001b7:\u00131:%3";
            s[189] = "\u0014Целевое время:\u0015%1";
            s[190] = "\u0014Лимит времени:\u0015%1";
            s[191] = "\u0014Лимит очков:\u0015%1";
            s[192] = "Введите ваше имя.\n\n\n";
            s[193] = "Новый рекорд!";
            s[194] = "Новый рекорд!";
            s[195] = "Впечатляюще!";
            s[196] = "\u001b2:Нужно выполнить \u001b23:САЛЬТО ОТ СТЕНЫ\u001b2:, чтобы пройти вызов.";
            s[197] = "\u001b2:Выполните \u001b23:ОПОРНЫЙ ПРЫЖОК\u001b2:, \u001b23:ПРЫЖОК ПАУКА\u001b2: и \u001b23:ОПОРНЫЙ С САЛЬТО\u001b2:.";
            s[198] = "\u001b2:Выполните \u001b23:ПРЫЖОК С ШЕСТА\u001b2:, \u001b23:СКОЛЬЖЕНИЕ\u001b2: и \u001b23:РАЗВОРОТ НА ШЕСТЕ\u001b2:.";
            s[199] = "\u001b2:Недостаточно очков. Попробуйте ещё раз.";
        }

        private static void ApplyGerman(string[] s, string driveUrl)
        {
            s[0] = "Ton"; s[1] = "Ja"; s[2] = "Nein"; s[4] = "Wahlen"; s[5] = "Zuruck"; s[6] = "Andern";
            s[7] = "Beenden"; s[8] = "Weiter"; s[9] = "Ein"; s[10] = "Aus"; s[11] = "Optionen";
            s[12] = "Rekorde loschen"; s[13] = "Spiel zurucksetzen"; s[14] = "Weiter"; s[15] = "Spiel beenden";
            s[16] = "Pause"; s[17] = "Weiter"; s[18] = "Laden"; s[19] = "Ton"; s[20] = "Einzelspieler";
            s[21] = "Mehrspieler"; s[22] = "Nochmal"; s[23] = "Mehr"; s[24] = "OK"; s[25] = "Spiel starten";
            s[26] = "Loschen"; s[27] = "Aufgeben"; s[28] = "Name eingeben"; s[29] = "Spieler"; s[30] = "Spieler %1";
            s[79] = "Allgemein"; s[81] = "Spielmodi"; s[83] = "Steuerung"; s[85] = "Tricks";
            s[90] = "Level wahlen"; s[91] = "Mission wahlen"; s[125] = "Rekord:"; s[130] = "Charakter wahlen";
            s[133] = "Ton einschalten"; s[134] = "Intro uberspr."; s[138] = "Start"; s[139] = "Rekorde";
            s[140] = "Info"; s[141] = "Hilfe"; s[142] = "Hauptmenu"; s[143] = "Spiel beenden";
            s[144] = "Spielen"; s[145] = "Weiter"; s[146] = "Spieler: %1"; s[147] = "Ergebnisse";
            s[148] = "Zeiten"; s[149] = "Punkte"; s[150] = "Rang"; s[154] = "Preis"; s[157] = "Gluckwunsch!";
            s[84] =
                "\u0014Oben\u0015\u001b23:\u00132:W, Oben, Leertaste\u001b3:\u00131:\n" +
                "\u0014Unten\u0015\u001b23:\u00132:S, Unten, Pad B\u001b3:\u00131:\n" +
                "\u0014Links\u0015\u001b23:\u00132:A, Links, Stick\u001b3:\u00131:\n" +
                "\u0014Rechts\u0015\u001b23:\u00132:D, Rechts, Stick\u001b3:\u00131:\n" +
                "\u0014Wahlen\u0015\u001b23:\u00132:Enter, Leertaste, A\u001b3:\u00131:\n" +
                "\u0014Pause\u0015\u001b23:\u00132:Esc, Start\u001b3:\u00131:\n" +
                "\u0014Hilfe\u0015\u001b23:\u00132:F1\u001b3:\u00131:\n" +
                "\u0014Modus\u0015\u001b23:\u00132:F2, Select\u001b3:\u00131:\n" +
                "\u0014Alle Level\u0015\u001b23:\u00132:F11\u001b3:\u00131:\n" +
                "\u0014Reset\u0015\u001b23:\u00132:F12";
            s[135] =
                "\u001b21:Playman Extreme Running\u001b3:\n" +
                "Version 1.0.4 (inoffizielles Remaster von FLEKSO)\n\n" +
                "© 2007 RealNetworks, Inc. Alle Rechte vorbehalten.\n\n" +
                "Verlegt von RealNetworks, Inc.\n" +
                "Entwickelt von Mr.Goodliving Ltd.\n";
            s[156] =
                "Hole deinen Preis unter: \n\n" +
                "www.playmansports.com/award/Wxxy9 (Website funktioniert nicht)\n\n" +
                "Preismaterial und mehr: " + driveUrl + " (Autor The Vault (youtube))";
        }

        private static void ApplyFrench(string[] s, string driveUrl)
        {
            s[0] = "Sons"; s[1] = "Oui"; s[2] = "Non"; s[4] = "Choisir"; s[5] = "Retour"; s[6] = "Changer";
            s[7] = "Quitter"; s[8] = "Reprendre"; s[9] = "Oui"; s[10] = "Non"; s[11] = "Options";
            s[12] = "Effacer scores"; s[13] = "Reinitialiser"; s[14] = "Reprendre"; s[15] = "Quitter partie";
            s[16] = "Pause"; s[17] = "Continuer"; s[18] = "Chargement"; s[19] = "Son"; s[20] = "Un joueur";
            s[21] = "Multijoueur"; s[22] = "Reessayer"; s[23] = "Plus"; s[24] = "OK"; s[25] = "Demarrer";
            s[26] = "Effacer"; s[27] = "Abandonner"; s[28] = "Votre nom"; s[29] = "Joueur"; s[30] = "Joueur %1";
            s[79] = "General"; s[81] = "Modes de jeu"; s[83] = "Commandes"; s[85] = "Figures";
            s[90] = "Choisir niveau"; s[91] = "Choisir mission"; s[125] = "Record:"; s[130] = "Choisir joueur";
            s[133] = "Activer le son"; s[134] = "Passer l'intro"; s[138] = "Jouer"; s[139] = "Scores";
            s[140] = "A propos"; s[141] = "Aide"; s[142] = "Menu principal"; s[143] = "Quitter le jeu";
            s[144] = "Jouer"; s[145] = "Suivant"; s[146] = "Joueurs: %1"; s[147] = "Resultats";
            s[148] = "Temps"; s[149] = "Score"; s[150] = "Classement"; s[154] = "Prix"; s[157] = "Felicitations!";
            s[84] =
                "\u0014Haut\u0015\u001b23:\u00132:W, Haut, Espace\u001b3:\u00131:\n" +
                "\u0014Bas\u0015\u001b23:\u00132:S, Bas, Pad B\u001b3:\u00131:\n" +
                "\u0014Gauche\u0015\u001b23:\u00132:A, Gauche, Stick\u001b3:\u00131:\n" +
                "\u0014Droite\u0015\u001b23:\u00132:D, Droite, Stick\u001b3:\u00131:\n" +
                "\u0014Choisir\u0015\u001b23:\u00132:Entree, Espace, A\u001b3:\u00131:\n" +
                "\u0014Pause\u0015\u001b23:\u00132:Esc, Start\u001b3:\u00131:\n" +
                "\u0014Aide\u0015\u001b23:\u00132:F1\u001b3:\u00131:\n" +
                "\u0014Mode\u0015\u001b23:\u00132:F2, Select\u001b3:\u00131:\n" +
                "\u0014Niveaux\u0015\u001b23:\u00132:F11\u001b3:\u00131:\n" +
                "\u0014Reset\u0015\u001b23:\u00132:F12";
            s[135] =
                "\u001b21:Playman Extreme Running\u001b3:\n" +
                "Version 1.0.4 (remaster non officiel par FLEKSO)\n\n" +
                "© 2007 RealNetworks, Inc. Tous droits reserves.\n\n" +
                "Edite par RealNetworks, Inc.\n" +
                "Developpe par Mr.Goodliving Ltd.\n";
            s[156] =
                "Recuperez votre prix sur : \n\n" +
                "www.playmansports.com/award/Wxxy9 (le site ne fonctionne pas)\n\n" +
                "Contenu du prix et plus : " + driveUrl + " (auteur The Vault (youtube))";
        }

        private static void ApplySpanish(string[] s, string driveUrl)
        {
            s[0] = "Sonidos"; s[1] = "Si"; s[2] = "No"; s[4] = "Elegir"; s[5] = "Atras"; s[6] = "Cambiar";
            s[7] = "Salir"; s[8] = "Continuar"; s[9] = "Si"; s[10] = "No"; s[11] = "Opciones";
            s[12] = "Borrar records"; s[13] = "Reiniciar juego"; s[14] = "Continuar"; s[15] = "Terminar";
            s[16] = "Pausa"; s[17] = "Continuar"; s[18] = "Cargando"; s[19] = "Sonido"; s[20] = "Un jugador";
            s[21] = "Multijugador"; s[22] = "Reintentar"; s[23] = "Mas"; s[24] = "OK"; s[25] = "Empezar";
            s[26] = "Borrar"; s[27] = "Rendirse"; s[28] = "Tu nombre"; s[29] = "Jugador"; s[30] = "Jugador %1";
            s[79] = "General"; s[81] = "Modos de juego"; s[83] = "Controles"; s[85] = "Movimientos";
            s[90] = "Elegir nivel"; s[91] = "Elegir mision"; s[125] = "Record:"; s[130] = "Elegir jugador";
            s[133] = "Activar sonido"; s[134] = "Saltar intro"; s[138] = "Inicio"; s[139] = "Records";
            s[140] = "Acerca de"; s[141] = "Ayuda"; s[142] = "Menu principal"; s[143] = "Salir del juego";
            s[144] = "Jugar"; s[145] = "Siguiente"; s[146] = "Jugadores: %1"; s[147] = "Resultados";
            s[148] = "Tiempos"; s[149] = "Puntos"; s[150] = "Ranking"; s[154] = "Premio"; s[157] = "Felicidades!";
            s[84] =
                "\u0014Arriba\u0015\u001b23:\u00132:W, Arriba, Espacio\u001b3:\u00131:\n" +
                "\u0014Abajo\u0015\u001b23:\u00132:S, Abajo, Pad B\u001b3:\u00131:\n" +
                "\u0014Izquierda\u0015\u001b23:\u00132:A, Izq., Stick\u001b3:\u00131:\n" +
                "\u0014Derecha\u0015\u001b23:\u00132:D, Der., Stick\u001b3:\u00131:\n" +
                "\u0014Elegir\u0015\u001b23:\u00132:Enter, Espacio, A\u001b3:\u00131:\n" +
                "\u0014Pausa\u0015\u001b23:\u00132:Esc, Start\u001b3:\u00131:\n" +
                "\u0014Ayuda\u0015\u001b23:\u00132:F1\u001b3:\u00131:\n" +
                "\u0014Modo\u0015\u001b23:\u00132:F2, Select\u001b3:\u00131:\n" +
                "\u0014Niveles\u0015\u001b23:\u00132:F11\u001b3:\u00131:\n" +
                "\u0014Reset\u0015\u001b23:\u00132:F12";
            s[135] =
                "\u001b21:Playman Extreme Running\u001b3:\n" +
                "Version 1.0.4 (remaster no oficial de FLEKSO)\n\n" +
                "© 2007 RealNetworks, Inc. Todos los derechos reservados.\n\n" +
                "Publicado por RealNetworks, Inc.\n" +
                "Desarrollado por Mr.Goodliving Ltd.\n";
            s[156] =
                "Recoge tu premio en: \n\n" +
                "www.playmansports.com/award/Wxxy9 (el sitio no funciona)\n\n" +
                "Material del premio y mas: " + driveUrl + " (autor The Vault (youtube))";
        }

        private static void ApplyItalian(string[] s, string driveUrl)
        {
            s[0] = "Suoni"; s[1] = "Si"; s[2] = "No"; s[4] = "Scegli"; s[5] = "Indietro"; s[6] = "Cambia";
            s[7] = "Esci"; s[8] = "Riprendi"; s[9] = "Si"; s[10] = "No"; s[11] = "Opzioni";
            s[12] = "Azzera record"; s[13] = "Azzera gioco"; s[14] = "Riprendi"; s[15] = "Termina";
            s[16] = "Pausa"; s[17] = "Continua"; s[18] = "Caricamento"; s[19] = "Suono"; s[20] = "Giocatore singolo";
            s[21] = "Multigiocatore"; s[22] = "Riprova"; s[23] = "Altro"; s[24] = "OK"; s[25] = "Inizia";
            s[26] = "Cancella"; s[27] = "Arrenditi"; s[28] = "Inserisci nome"; s[29] = "Giocatore"; s[30] = "Giocatore %1";
            s[79] = "Generale"; s[81] = "Modalita"; s[83] = "Comandi"; s[85] = "Mosse";
            s[90] = "Scegli livello"; s[91] = "Scegli missione"; s[125] = "Record:"; s[130] = "Scegli personaggio";
            s[133] = "Attiva audio"; s[134] = "Salta intro"; s[138] = "Inizia"; s[139] = "Record";
            s[140] = "Info"; s[141] = "Aiuto"; s[142] = "Menu principale"; s[143] = "Esci dal gioco";
            s[144] = "Gioca"; s[145] = "Avanti"; s[146] = "Giocatori: %1"; s[147] = "Risultati";
            s[148] = "Tempi"; s[149] = "Punti"; s[150] = "Classifica"; s[154] = "Premio"; s[157] = "Complimenti!";
            s[84] =
                "\u0014Su\u0015\u001b23:\u00132:W, Su, Spazio\u001b3:\u00131:\n" +
                "\u0014Giu\u0015\u001b23:\u00132:S, Giu, Pad B\u001b3:\u00131:\n" +
                "\u0014Sinistra\u0015\u001b23:\u00132:A, Sin., Stick\u001b3:\u00131:\n" +
                "\u0014Destra\u0015\u001b23:\u00132:D, Des., Stick\u001b3:\u00131:\n" +
                "\u0014Scegli\u0015\u001b23:\u00132:Invio, Spazio, A\u001b3:\u00131:\n" +
                "\u0014Pausa\u0015\u001b23:\u00132:Esc, Start\u001b3:\u00131:\n" +
                "\u0014Aiuto\u0015\u001b23:\u00132:F1\u001b3:\u00131:\n" +
                "\u0014Modalita\u0015\u001b23:\u00132:F2, Select\u001b3:\u00131:\n" +
                "\u0014Livelli\u0015\u001b23:\u00132:F11\u001b3:\u00131:\n" +
                "\u0014Reset\u0015\u001b23:\u00132:F12";
            s[135] =
                "\u001b21:Playman Extreme Running\u001b3:\n" +
                "Versione 1.0.4 (remaster non ufficiale di FLEKSO)\n\n" +
                "© 2007 RealNetworks, Inc. Tutti i diritti riservati.\n\n" +
                "Pubblicato da RealNetworks, Inc.\n" +
                "Sviluppato da Mr.Goodliving Ltd.\n";
            s[156] =
                "Ritira il tuo premio su: \n\n" +
                "www.playmansports.com/award/Wxxy9 (il sito non funziona)\n\n" +
                "Materiale del premio e altro: " + driveUrl + " (autore The Vault (youtube))";
        }
    }
}
