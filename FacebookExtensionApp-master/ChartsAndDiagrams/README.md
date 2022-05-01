# Facebook Extension App Charts & Diagrams

## System Diagram

### Basic Use Case Diagram
![App basic use case diagram](BasicUseCaseDiagram.png)

### System Sequence Diagram Travel Diary
![System Sequence Diagram Travel Diary](SystemSequenceDiagramTravelDiary.jpeg)

## Design Patterns

### Singleton
Based on the singleton design pattern:

Singleton :arrow_right: FacebookUser

Client :arrow_right: FormMain         

#### Sequence Diagram
![System Sequence Diagram](DesignPatterns/Singleton/SystemSequenceDiagram.png)

#### Class Diagram
![Facebook User Class Diagram](DesignPatterns/Singleton/FacebookUserClassDiagram.png)

### Factory Method
Based on the Factory Method design pattern:

Client :arrow_right: FormHomePage      

StaticFactoryClass :arrow_right: PostCreator  

AbstractClass :arrow_right: FacebookPost    

ConcreteProudct1 :arrow_right: TextPost    

ConcreteProudct2 :arrow_right: PhotoPost         

#### Sequence Diagram
![System Sequence Diagram](DesignPatterns/FactoryMethod/FactoryMethod.png)

#### Class Diagram
![ Factory Method Class Diagram](DesignPatterns/FactoryMethod/FactoryMethodClassDiagram.png)

### Builder 
Based on the Builder design pattern:

Director :arrow_right: SoulmateCreator    

Builder :arrow_right: ISoulmateBuilder     

Concrete Builder :arrow_right: SoulmateFriendBuilder   

Product :arrow_right: SoulmateFriend                         

#### Sequence Diagram
![Builder System Sequence Diagram](DesignPatterns/Builder/Builder.jpg)

#### Class Diagram
![Builder Class Diagram](DesignPatterns/Builder/BuilderClassDiagram.jpg)

### Command 
Based on the Command design pattern:

Client :arrow_right: MainForm    

Command :arrow_right: ICommand     

ConcreteCommand :arrow_right: OpenFormFromMainFormPanelCommand      

Invoker :arrow_right: FeatureButton                         

#### Sequence Diagram
![Command System Sequence Diagram](DesignPatterns/Command/Command.png)

#### Class Diagram
![Command Class Diagram](DesignPatterns/Command/CommandClassDiagram.png)

### Stratrgy 
Based on the Stratrgy design pattern:

Mechanisem  :arrow_right: SoulmateFounderLogic  

IStrategy  :arrow_right: ICountCategoryStrategy     

Strategy1 :arrow_right: MaxCategoryManager                                          

#### Sequence Diagram
![Stratrgy System Sequence Diagram](DesignPatterns/Stratrgy/Stratrgy.png)

#### Class Diagram
![Stratrgy Class Diagram](DesignPatterns/Stratrgy/StratrgyClassDiagram.png)

### Decorator 
Based on the Decorator design pattern:

IComponent   :arrow_right: IPictureDecorated      

SomeCoreComponent  :arrow_right: PictureCoreDecoratoed    

Decorator :arrow_right: PictureDecorator     

ConcreteDecoratorOne :arrow_right: FlickeringPicture       

ConcretDecoratorTwo :arrow_right: RoundEdgesPicture                                           

#### Sequence Diagram
![Decorator System Sequence Diagram](DesignPatterns/Decorator/Decorator.jpg)

#### Class Diagram
![Decorator Class Diagram](DesignPatterns/Decorator/DecoratorClassDiagram.png)
