# 🎮 Agent Sensor Game / משחק חקירת סוכן

> A turn-based game where you play as an investigator trying to expose an agent's weaknesses using sensors.  
> משחק מבוסס תורות, בו אתה מנסה "לשבור" את הסוכן בעזרת חיישנים שמכוונים לחולשות שלו.

---

## 📁 Folder Structure / מבנה תיקיות

```
Sensors/
│
├── IAgent.cs         # Interface for agents / ממשק לסוכן
├── ISensor.cs        # Interface for sensors / ממשק לחיישן
├── Sensor.cs         # (Optional) Concrete sensor class / מחלקת חיישן ממשית (אם תתבצע)
├── Menu.cs           # Game menu logic / תפריט המשחק
├── Manager.cs        # Main game logic (turns, checking) / ניהול המשחק
├── Program.cs        # Entry point / נקודת כניסה
├── Properties/
│   └── AssemblyInfo.cs
└── obj/
    └── Debug/
        └── .NETFramework,Version=v4.7.2.AssemblyAttributes.cs
```

---

## 🧠 Game Logic / לוגיקת המשחק

### 🎯 Goal / מטרה
- Use sensors to match and reduce the weaknesses of an agent.
- When all weaknesses reach 0 – the agent is "broken" and you win!
- עליך להשתמש בחיישנים מתאימים לחולשות הסוכן.  
  כשהכול מגיע ל־0 – ניצחת!

### 🔁 Flow / מהלך

1. Display menu – user selects an interrogation room  
   מציגים תפריט – המשתמש בוחר חדר חקירה

2. Load an agent with a dictionary of weaknesses:  
   טוענים סוכן עם מילון חולשות:

```csharp
Dictionary<string, int> Weaknesses = new Dictionary<string, int>()
{
    { "Thermal Sensor", 2 },
    { "Sound Detector", 1 },
    { "Pressure Sensor", 3 }
};
```

3. Each turn:
   - Ask the player to choose a sensor
   - If the sensor matches a weakness – subtract 1
   - If not – just skip to the next turn
   כל תור:
   - שואל את החוקר איזה חיישן לבחור
   - אם תואם לחולשה → מורידים 1
   - אם לא → לא קורה כלום

4. When all dictionary values are zero → display win message  
   כאשר כל הערכים במילון = 0 → הודעת ניצחון

```csharp
Console.WriteLine("ניצחת את הסוכן! / You defeated the agent!");
```

---

## 🛠 Technologies

- C# .NET Framework 4.7.2
- Console Application

---

## 🧩 Interfaces

### `IAgent`
```csharp
interface IAgent
{
    string name { get; set; }
    Dictionary<string, int> sensor { get; set; } // weaknesses
}
```

### `ISensor`
```csharp
interface ISensor
{
    string name { get; set; }
    bool active { get; set; }
}
```

---

## 🧑‍💻 Author

Created by Yossi (יוסי)

---