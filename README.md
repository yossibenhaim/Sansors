# 💡 Sensors Simulation Game

סימולציית משחק המדמה מערכת של סוכנים וחיישנים, שנכתבה בשפת C# תוך שימוש בעקרונות תכנות מונחה עצמים (OOP).

---

## 🧾 תוכן עניינים
- [על הפרויקט](#על-הפרויקט)
- [הרצה](#הרצה)
- [מבנה המערכת](#מבנה-המערכת)
- [עקרונות OOP](#עקרונות-oop)
- [אפשרויות להרחבה](#אפשרויות-להרחבה)
- [מבנה התיקיות](#מבנה-התיקיות)

---

## על הפרויקט

במשחק זה, סוכן מצויד בחיישנים שונים על מנת לזהות ולטפל בחולשות קיימות. מטרת השחקן היא לחבר את החיישנים הנכונים למיקומים המתאימים, עד שכל החולשות טופלו.

🧠 **מטרת הלמידה**:  
תרגול מושגים מתקדמים של OOP כמו ירושה, פולימורפיזם, ממשקים ואינקאפסולציה.

---

## הרצה

1. פתח את הקובץ `Sansors.sln` ב־Visual Studio.
2. ודא שקובץ `Program.cs` הוא נקודת ההתחלה (`Startup object`).
3. הרץ את התוכנית (F5).
4. פעל לפי התפריטים במסוף — בחר חיישנים, חבר אותם לסוכן, וטפל בחולשות עד לסיום המשחק.

---

## מבנה המערכת

### 🧩 מחלקות עיקריות

| אזור | קובץ | תיאור |
|------|------|--------|
| `UI/Dispaly.cs` | `Dispaly` | מנהל את זרימת המשחק והתפריטים |
| `Agents/Agent.cs` | `Agent` | מחלקת בסיס לכל סוכן |
| `Agents/SquadLeader.cs` | `SquadLeader` | סוכן שמסיר חיישן כל 3 חיבורים |
| `Manager/Manager.cs` | `Manager` | בודק אם הסנסור מתאים, מפעיל את החיישן |
| `Sensors/Sensor.cs` | `Sensor` | מחלקת בסיס לחיישנים |
| `Sensors/AudioSensor.cs` | `AudioSensor` | חיישן שמע |
| `Sensors/ThermalSensor.cs` | `ThermalSensor` | חיישן תרמי |
| `Sensors/PlusSensor.cs` | `PlusSensor` | חיישן שמפסיק לפעול לאחר 3 פעמים |
| `Manager/HelpManager.cs` | `HelpManager` | פונקציות עזר סטטיסטיות |
| `Manager/Printer.cs` | `Printer` | הדפסות למסך |
| `interface/IAgent.cs` | `IAgent` | חוזה לסוכנים |
| `interface/ISensor.cs` | `ISensor` | חוזה לחיישנים |

---

## עקרונות OOP

- ✅ **Encapsulation** – כל רכיב אחראי רק לתחום שלו.
- ✅ **Inheritance** – סוכנים יורשים מ־`Agent`, חיישנים מ־`Sensor`.
- ✅ **Polymorphism** – מימושים שונים של `Active()` בהתאם לחיישן.
- ✅ **Interfaces** – שימוש ב־`IAgent` ו־`ISensor` למבנה אחיד וגמיש.

---

## אפשרויות להרחבה

- 🧠 אלגוריתם בחירה אוטומטי של חיישנים
- 📊 לוג פעילות/קובץ לוג
- 🖼️ ממשק גרפי WPF או WinForms
- 🔁 תמיכה במספר סוכנים במקביל
- 💾 שמירת מצב לקובץ

---

## מבנה התיקיות

```plaintext
Sansors/
├── Agents/
│   ├── Agent.cs
│   ├── FootAgent.cs
│   └── SquadLeader.cs
│
├── interface/
│   ├── IAgent.cs
│   └── ISensor.cs
│
├── Manager/
│   ├── HelpManager.cs
│   ├── Manager.cs
│   └── Printer.cs
│
├── Sensors/
│   ├── AudioSensor.cs
│   ├── PlusSensor.cs
│   ├── Sensor.cs
│   └── ThermalSensor.cs
│
├── UI/
│   └── Dispaly.cs
│
├── Program.cs
├── App.config
└── Sansors.sln
