﻿## Snippetica.CSharp

### Quick Reference

* Default access modifier is **public**.

Character\(s\) | Description | Comment
------------ | ----------- | -------
\_|interface member|prefix
\_|with initializer|suffix
\_|with parameters|suffix
a|Array|\-
b|Boolean|\-
c|catch|\-
c|class declaration|\-
c|Collection\<T\>|\-
co|conditional operator|\-
cr|constructor declaration|\-
d|default|\-
d|Dictionary\<TKey,TValue\>|\-
de|delegate declaration|\-
dt|DateTime|\-
e|else clause|\-
e|IEnumerable\<T\>|\-
em|enum declaration|\-
et|event declaration|\-
f|false|\-
f|field declaration|\-
f|finally|\-
fe|foreach statement|\-
fr|for statement|\-
g|generic type|prefix
g|type parameter|\-
hs|HashSet\<T\>|\-
i|Immutable|prefix
i|Int32|\-
i|internal \(Friend\)|prefix
ie|inteface declaration|\-
if|if statement|\-
ir|indexer declaration|\-
k|constant declaration|\-
l|Int64|\-
l|lambda expression|\-
l|List\<T\>|\-
ll|LinkedList\<T\>|\-
m|method declaration|\-
n|\(equal to\) null|\-
n|new object creation|\-
nn|not \(equal to\) null|\-
no|nameof operator|\-
o|Object|\-
oc|ObservableCollection\<T\>|\-
oo|operator overload|\-
p|private|prefix
p|property declaration|\-
pa|parameter array|\-
pp|preprocessor directive|prefix
pp|property declaration \(expanded\)|\-
ps|private set|\-
q|Queue\<T\>|\-
r|read\-only|\-
r|return|\-
re|return|\-
s|Stack\<T\>|\-
s|static \(Shared\)|prefix \(after access modifier\)
s|String|\-
sh|switch statement|\-
st|struct|\-
t|explict cast operator|\-
t|true|\-
t|try|\-
this|containing type name|\-
to|typeof operator|\-
tw|throw statement|\-
u|using statement|\-
v|local variable|prefix
v|virtual \(Overridable\)|prefix \(after access modifier\)
we|while statement|\-
y|yield|\-

* [full list of snippets](http://pihrt.net/Snippetica/Snippets?Language=CSharp)

### List of Selected Snippets

Title | Shortcut
----- | --------
[?: operator](ConditionalOperator.snippet)|co
[\!string\.IsNullOrEmpty](StringIsNotNullOrEmpty.snippet)|snne
[\!string\.IsNullOrWhiteSpace](StringIsNotNullOrWhiteSpace.snippet)|snnw
[\#if preprocessor directive](PreprocessorDirectiveIf.snippet)|ppif
[\#if\-\#else preprocessor directive](PreprocessorDirectiveIfElse.snippet)|ppife
[\#region preprocessor directive](PreprocessorDirectiveRegion.snippet)|ppr
[== operator overload](OperatorOverloadEquality.snippet)|oo
[array variable](ArrayOfTVariable.snippet)|va
[Attribute class](AttributeClass.snippet)|c\_
[Boolean variable](BooleanVariable.snippet)|vb
[braces](Braces.snippet)|b
[catch](Catch.snippet)|catch
[Collection\<T\> class](CollectionOfTClass.snippet)|c\_
[containing type name](ContainingTypeName.snippet)|this
[DateTime type](DateTimeType.snippet)|dt
[Debug\.Assert](DebugAssert.snippet)|da
[Debug\.WriteLine](DebugWriteLine.snippet)|dw
[default keyword](DefaultKeyword.snippet)|d
[Dictionary\<TKey, TValue\> class](DictionaryOfTKeyTValueClass.snippet)|c\_
[Disposable class](DisposableClass.snippet)|c\_
[dispose pattern](Dispose.snippet)|dispose
[else\-if](ElseIf.snippet)|eif
[else](Else.snippet)|e
[equal to null](EqualToNull.snippet)|n
[Equals and GetHashCode for value type](EqualsAndGetHashCodeForValueType.snippet)|equals
[Equals and GetHashCode](EqualsAndGetHashCode.snippet)|equals
[Exception class](ExceptionClass.snippet)|c\_
[explicit cast operator](ExplicitCastOperator.snippet)|t
[finally](Finally.snippet)|finally
[for \(reversed\)](ForReversed.snippet)|frr
[for](For.snippet)|fr
[foreach statement](Foreach.snippet)|fe
[generic type constraint](GenericTypeConstraint.snippet)|where
[IComparer class](IComparerClass.snippet)|c\_
[IComparer\<T\> class](IComparerOfTClass.snippet)|c\_
[IEnumerable\<T\> type](IEnumerableOfTType.snippet)|ge
[IEnumerator\<T\> variable](IEnumeratorOfTVariable.snippet)|u
[IEqualityComparer class](IEqualityComparerClass.snippet)|c\_
[IEqualityComparer\<T\> class](IEqualityComparerOfTClass.snippet)|c\_
[if equal to null](IfEqualToNull.snippet)|ifn
[if not equal to null](IfNotEqualToNull.snippet)|ifnn
[if not TryParse](IfNotTryParse.snippet)|ifftp
[if not](IfNot.snippet)|iff
[if TryParse](IfTryParse.snippet)|iftp
[Int32 variable](Int32Variable.snippet)|vi
[interface indexer](InterfaceIndexer.snippet)|\_ir
[interface method](InterfaceMethod.snippet)|\_m
[interface property](InterfaceProperty.snippet)|\_p
[interface read\-only property](InterfaceReadOnlyProperty.snippet)|\_rp
[lambda expression](LambdaExpression.snippet)|l
[nameof operator](NameOfOperator.snippet)|no
[new variable](NewVariable.snippet)|vn
[not equal to null](NotEqualToNull.snippet)|nn
[object keyword](ObjectKeyword.snippet)|o
[ObservableCollection\<T\> class](ObservableCollectionOfTClass.snippet)|c\_
[parameter array ](ParameterArray.snippet)|pa
[public auto property with private setter](PublicAutoPropertyWithPrivateSet.snippet)|pps
[public auto property](PublicAutoProperty.snippet)|p
[public class](PublicClass.snippet)|c
[public const](PublicConst.snippet)|k
[public constructor](PublicConstructor.snippet)|cr
[public delegate](PublicDelegate.snippet)|de
[public enum](PublicEnum.snippet)|em
[public event](PublicEvent.snippet)|et
[public field](PublicField.snippet)|f
[public indexer](PublicIndexer.snippet)|ir
[public interface](PublicInterface.snippet)|ie
[public method](PublicMethod.snippet)|m
[public read\-only auto property](PublicReadOnlyAutoProperty.snippet)|rp
[public read\-only field](PublicReadOnlyField.snippet)|rf
[public read\-only property](PublicReadOnlyProperty.snippet)|rpp
[public static class](PublicStaticClass.snippet)|sc
[public static field](PublicStaticField.snippet)|sf
[public static method](PublicStaticMethod.snippet)|sm
[public static read\-only auto property](PublicStaticReadOnlyAutoProperty.snippet)|srp
[public static read\-only field](PublicStaticReadOnlyField.snippet)|srf
[public static read\-only property](PublicStaticReadOnlyProperty.snippet)|srpp
[public struct](PublicStruct.snippet)|st
[public virtual auto property](PublicVirtualAutoProperty.snippet)|vp
[public virtual method](PublicVirtualMethod.snippet)|vm
[public virtual read\-only auto property](PublicVirtualReadOnlyAutoProperty.snippet)|vrp
[public virtual read\-only property](PublicVirtualReadOnlyProperty.snippet)|vrpp
[ReadOnlyCollection\<T\> class](ReadOnlyCollectionOfTClass.snippet)|c\_
[return false](ReturnFalse.snippet)|ref
[return keyword](ReturnKeyword.snippet)|r
[return null](ReturnNull.snippet)|ren
[return true](ReturnTrue.snippet)|ret
[Singleton class](SingletonClass.snippet)|c\_
[static constructor](StaticConstructor.snippet)|scr
[StreamReader Variable](StreamReaderVariable.snippet)|u
[StreamWriter Variable](StreamWriterVariable.snippet)|u
[string keyword](StringKeyword.snippet)|s
[String variable](StringVariable.snippet)|vs
[string\.IsNullOrEmpty](StringIsNullOrEmpty.snippet)|sne
[string\.IsNullOrWhiteSpace](StringIsNullOrWhiteSpace.snippet)|snw
[StringReader Variable](StringReaderVariable.snippet)|u
[StringWriter Variable](StringWriterVariable.snippet)|u
[switch](Switch.snippet)|sh
[throw new](ThrowNew.snippet)|twn
[TODO comment](TodoComment.snippet)|td
[try\-catch\-finally](TryCatchFinally.snippet)|tcf
[try\-catch](TryCatch.snippet)|tc
[try\-finally](TryFinally.snippet)|tf
[type parameter](TypeParameter.snippet)|g
[typeof operator](TypeOfOperator.snippet)|to
[using statement](Using.snippet)|u
[using static](UsingStatic.snippet)|us
[using variable](UsingVariable.snippet)|u
[variable declaration with explicit cast operator](VariableWithExplicitCast.snippet)|vt
[variable declaration](Variable.snippet)|v
[while](While.snippet)|we
[XmlReader Variable](XmlReaderVariable.snippet)|u
[XmlWriter Variable](XmlWriterVariable.snippet)|u
[yield break](YieldBreak.snippet)|yb
[yield return](YieldReturn.snippet)|yr
