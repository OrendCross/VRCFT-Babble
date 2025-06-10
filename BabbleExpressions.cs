using VRCFaceTracking.Babble.Collections;
using VRCFaceTracking.Core.Params.Expressions;

namespace VRCFaceTracking.Babble;

public static class BabbleExpressions
{
    public static readonly TwoKeyDictionary<UnifiedExpressions, string, float> BabbleExpressionMap = new TwoKeyDictionary<UnifiedExpressions, string, float>
    {
        {
            UnifiedExpressions.TongueOut,
            "/tongueOut",
            0f
        },
        {
            UnifiedExpressions.TongueUp,
            "/tongueUp",
            0f
        },
        {
            UnifiedExpressions.TongueDown,
            "/tongueDown",
            0f
        },
        {
            UnifiedExpressions.TongueLeft,
            "/tongueLeft",
            0f
        },
        {
            UnifiedExpressions.TongueRight,
            "/tongueRight",
            0f
        },
        {
            UnifiedExpressions.TongueRoll,
            "/tongueRoll",
            0f
        },
        {
            UnifiedExpressions.TongueBendDown,
            "/tongueBendDown",
            0f
        },
        {
            UnifiedExpressions.TongueCurlUp,
            "/tongueCurlUp",
            0f
        },
        {
            UnifiedExpressions.TongueSquish,
            "/tongueSquish",
            0f
        },
        {
            UnifiedExpressions.TongueFlat,
            "/tongueFlat",
            0f
        },
        {
            UnifiedExpressions.TongueTwistLeft,
            "/tongueTwistLeft",
            0f
        },
        {
            UnifiedExpressions.TongueTwistRight,
            "/tongueTwistRight",
            0f
        }
    };
}
