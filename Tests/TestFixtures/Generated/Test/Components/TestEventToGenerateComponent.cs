//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity {

    public EventToGenerateComponent eventToGenerate { get { return (EventToGenerateComponent)GetComponent(TestComponentsLookup.EventToGenerate); } }
    public bool hasEventToGenerate { get { return HasComponent(TestComponentsLookup.EventToGenerate); } }

    public void AddEventToGenerate(My.Namespace.EventToGenerate newValue) {
        var index = TestComponentsLookup.EventToGenerate;
        var component = CreateComponent<EventToGenerateComponent>(index);
        component.value = newValue;
        AddComponent(index, component);
    }

    public void ReplaceEventToGenerate(My.Namespace.EventToGenerate newValue) {
        var index = TestComponentsLookup.EventToGenerate;
        var component = CreateComponent<EventToGenerateComponent>(index);
        component.value = newValue;
        ReplaceComponent(index, component);
    }

    public void RemoveEventToGenerate() {
        RemoveComponent(TestComponentsLookup.EventToGenerate);
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class TestEntity : IEventToGenerate { }

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class TestMatcher {

    static Entitas.IMatcher<TestEntity> _matcherEventToGenerate;

    public static Entitas.IMatcher<TestEntity> EventToGenerate {
        get {
            if (_matcherEventToGenerate == null) {
                var matcher = (Entitas.Matcher<TestEntity>)Entitas.Matcher<TestEntity>.AllOf(TestComponentsLookup.EventToGenerate);
                matcher.componentNames = TestComponentsLookup.componentNames;
                _matcherEventToGenerate = matcher;
            }

            return _matcherEventToGenerate;
        }
    }
}