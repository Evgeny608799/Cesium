using Cesium.CodeGen.Ir.Expressions;
using Yoakke.C.Syntax;

namespace Cesium.CodeGen.Extensions;

internal static class ExpressionEx
{
    public static IExpression ToIntermediate(this Ast.Expression ex) => ex switch
    {
        Ast.ConstantExpression { Constant.Kind: CTokenType.Identifier } e => new IdentifierConstantExpression(e),
        Ast.ConstantExpression e => new ConstantExpression(e),

        Ast.FunctionCallExpression e => new FunctionCallExpression(e),

        Ast.PrefixIncrementExpression e => new PrefixIncrementExpression(e),

        Ast.AssignmentExpression e => new AssignmentExpression(e),
        Ast.BinaryOperatorExpression e => new BinaryOperatorExpression(e),

        // TODO[#73]: Uncomment this.
        // _ => throw new NotImplementedException($"Expression not supported, yet: {ex}."),
        _ => new AstExpression(ex)
    };
}
