Imports inoTestBuildDLL
Imports NUnit.Framework

Namespace TestInoBuild

    Public Class TestClsMath
        Private cMath As New ClsMath
        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub TestAddition()
            Assert.AreEqual(5, cMath.addition(2, 3))
        End Sub

        <Test>
        Public Sub TestSibstraction()
            Assert.AreEqual(-1, cMath.substraction(2, 3))
        End Sub

    End Class

End Namespace