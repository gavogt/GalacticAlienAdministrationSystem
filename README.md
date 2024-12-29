Assignment Title
Design and Implement a Modular “Galactic Alien Administration” in .NET 8.0 Using Multiple Design Patterns and Head First OOP Principles

Scenario Overview
The Interplanetary Council has decreed that Earth will now host various alien species for research, cultural exchange, and tourism. Your task is to design and (optionally) prototype a “Galactic Alien Administration” system that manages:

Alien Visitors (individual beings)
Alien Groups/Delegations (organized groups traveling together)
Planetary Facilities (Embassies, Research Centers, or Quarantine Zones)
Arrival & Temporary Settlement processes
Aliens from different galaxies should be able to request temporary accommodation or usage of Earth’s facilities. The system also needs to track each alien’s profile, scheduling, and any specialized requirements (e.g., anti-gravity chambers or radiation shielding).

Using .NET 8.0, you must build your solution in line with object-oriented design principles (as explained in Head First Design Patterns) and integrate five or six design patterns. Explain which patterns you chose, why you chose them, and how they address specific design needs.

OOP Design Principles from Head First
Make sure to highlight how you use the following principles throughout your design:

Encapsulate What Varies

Any parts of the system likely to change (e.g., new alien species with unique needs, new facility types, different travel regulations) should be encapsulated.
Favor Composition Over Inheritance

Where appropriate, compose behavior from smaller objects rather than relying on deep inheritance hierarchies.
Program to Interfaces, Not Implementations

Use interfaces (or abstract classes) for key subsystems (e.g., facility operations, alien identity management), decoupling clients from concrete classes.
Strive for Loosely Coupled Designs

Keep dependencies minimal. If one module changes (e.g., how you notify alien delegates of a new schedule), it should not break everything else.
Open for Extension, Closed for Modification

Make it easy to add new alien categories or facility types without overhauling stable, existing code.
Depend Upon Abstractions, Not Concretions

Rely on abstract interfaces or base classes (e.g., ISpeciesBehavior) so you can swap in different implementations (e.g., ReptilianBehavior, EnergyBeingsBehavior).
Law of Demeter (“Don’t Talk to Strangers”)

Ensure objects only interact with their immediate collaborators and do not dig deeply into object structures they shouldn’t be aware of.


Key Functional Requirements

Alien Registration & Management
Individual Aliens: personal data, species, special requirements, visit duration.
Alien Groups/Delegations: grouped aliens traveling under a single request.
Basic verification procedures (e.g., ensuring they are cleared for Earth’s atmosphere).

Facility Listing & Availability
Planetary facilities (e.g., embassies, research labs, quarantine zones) each have unique features (capacity, specialized environmental controls, etc.).
Administrators can mark facilities as “available” or “under maintenance.”

Visitation Scheduling & Booking
Aliens or their delegation leaders can request time slots in specific facilities.
Approval by Earth Admins or auto-approval depending on the facility rules.

Notification & Alerts
Any changes to bookings, new arrivals, or facility statuses trigger notifications to relevant stakeholders (aliens, Earth Admins, facility managers).
Must be easy to add new notification channels in the future (e.g., galactic telepathy, cosmic mail).

Search & Browsing (Optional Extension)
Aliens can search for facilities by capacity, environment type (oxygen, methane, vacuum), or other special equipment.
Earth Admins can quickly filter which alien groups have not yet been assigned a facility.

Reports & Monitoring (Optional Extension)
Earth Admins might want to see the current occupancy of each facility, overall usage statistics, or trends by alien species.
The system should be open for future analytics expansions.



Design & Implementation Requirements (.NET 8.0)
Implement your solution (or a partial prototype) using .NET 8.0, emphasizing:
Modern C# language features (e.g., pattern matching, record types, nullable references).
Head First OOP principles (above).
5 or 6 design patterns from the recommended list (or others that fit). Each pattern must address a real design problem in your scenario.

Recommended Design Patterns

Singleton
Central management for global configurations (e.g., universal rules of visitation, cosmic event schedules, shared logging/monitoring).

Factory / Abstract Factory
To create different Facility types (EmbassyFactory, ResearchLabFactory, QuarantineZoneFactory) or different Alien objects if you have various species with unique instantiation.

Strategy
Different scheduling or booking rules (e.g., some facilities require manual approval, others auto-approve if capacity is free).
Could also manage diverse search strategies.

Observer
Notification subsystem where observers (email, cosmic communicator, in-app push) subscribe to events (new booking, booking cancellation, facility maintenance).

Decorator
Adding optional “features” to a facility or an alien’s booking without altering the core class (e.g., special environmental controls, VIP protocls for high-ranking aliens).

Command
Encapsulate booking and scheduling requests as commands, facilitating undo/redo or delayed execution of certain tasks (e.g., sending arrival reminders 24 hours in advance).

Facade
Provide a simplified interface for complex operations (e.g., scheduling logic, species compliance checks, and notifications).

State
Manage facility or booking states (e.g., Requested, Approved, UnderMaintenance, Closed), controlling transitions in a structured way.
Feel free to include any other patterns that align with your needs.

What to Deliver
High-Level Architecture Diagram

Illustrate how key subsystems (Alien Management, Facility Management, Booking System, Notification System) interact in .NET 8.0.
Class Diagrams

Show major classes, their relationships (interfaces, composition), and indicate where each design pattern is used.
Highlight how you encapsulated what varies and avoided tight coupling.
Sequence or Flow Diagrams

Capture critical scenarios:
Registering a New Alien / Alien Group
Listing or Updating a Facility
Requesting and Approving a Facility Booking
Notification Dispatch (via Observer or relevant pattern)
Design Principles & Patterns Explanation

Provide a short report explaining which OOP principles and which design patterns you used.
Clarify how each principle (e.g., “Open for Extension, Closed for Modification”) and pattern (e.g., Strategy, Decorator) solved a particular challenge.
Prototype Code (Optional Yet Encouraged)

If you build a sample .NET 8.0 project (console or minimal web app), demonstrate usage of your patterns (e.g., an endpoint for booking a facility, a small class library with Factories and Observers).
Your prototype doesn’t have to be fully production-ready, just enough to highlight the design.
Grading Criteria
Design Clarity (30%)

Logical architecture, reflecting the aliens/facilities domain.
Effective use of encapsulation, abstraction, and composition.
Application of OOP Principles (20%)

Demonstrating each Head First principle (encapsulate what varies, favor composition, etc.) in meaningful parts of your system.
Appropriate Use of Design Patterns (20%)

At least five or six patterns applied.
Patterns clearly address real design problems (not just “pattern for pattern’s sake”).
Extensibility & Maintainability (20%)

System can easily adapt to new alien species, facility types, or notification channels.
Minimal impact on stable code when adding features.
Documentation & Presentation (10%)

Clear, well-labeled diagrams.
Concise explanations linking patterns and principles to design challenges.
Important Notes
You’re not required to implement advanced external services (database, cosmic payment gateways, etc.), but you should design for them (i.e., show how they would be integrated).
Focus on why a given pattern or principle is needed, and how it improves flexibility and maintainability in the alien domain.
If you provide partial code, ensure it compiles or runs under .NET 8.0.
For expansions, consider how adding a brand-new facility type (e.g., “Undersea Lab for Aquatic Aliens”) or a new species with specialized environment needs might be done without rewriting core logic.
Submission Format
A written report (PDF or Word) with diagrams and pattern explanations.
(Optional) A .zip or .rar file containing your .NET 8.0 prototype project to demonstrate the patterns in action.
End of Assignment
