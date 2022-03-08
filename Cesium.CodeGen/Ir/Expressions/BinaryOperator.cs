namespace Cesium.CodeGen.Ir.Expressions;

public enum BinaryOperator
{
    Add, // +
    Multiply, // *

    Assign, // =
    AddAndAssign, // +=
    MultiplyAndAssign, // *=

    BitwiseLeftShift, // <<
    BitwiseRightShift, // >>
    BitwiseOr, // |
    BitwiseAnd, // &
    BitwiseXor, // ^
}
