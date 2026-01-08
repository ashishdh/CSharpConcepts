namespace OOPSConcepts
{
    public abstract class BaseLanguageModel
    {
        public virtual string Tokenize(string text)
        {
            return $"Tokenized text: {text}";
        }

        public virtual string Generate(string prompt)
        {
            return "Base model generation";
        }
    }

    public abstract class TransformerModel : BaseLanguageModel
    {
        public virtual string SelfAttention(string tokens)
        {
            return $"Applying self-attention on: {tokens}";
        }
    }

    public abstract class DecoderOnlyTransformer : TransformerModel
    {
        public virtual string CausalMasking()
        {
            return "Applying causal masking (no future tokens)";
        }
    }

    public class GptModel : DecoderOnlyTransformer
    {
        public override string Generate(string prompt)
        {
            var tokens = Tokenize(prompt);
            var attention = SelfAttention(tokens);
            var mask = CausalMasking();

            return $"GPT Output using [{attention}] and [{mask}]";
        }
    }

    // Separate demo runner for inheritance/transformer examples
    internal static class InheritanceDemo
    {
        public static void Run()
        {
            System.Console.WriteLine("========= INHERITANCE / TRANSFORMER DEMO =========\n");

            // Direct concrete usage
            GptModel gpt = new GptModel();
            System.Console.WriteLine("GptModel.Generate(): " + gpt.Generate("Hello Transformer"));

            // Use base-class reference to the derived object
            BaseLanguageModel baseRef = gpt;
            System.Console.WriteLine("BaseLanguageModel reference calling Generate(): " + baseRef.Generate("Prompt via base ref"));

            // Use intermediate TransformerModel reference and show SelfAttention + Tokenize
            TransformerModel transformerRef = gpt;
            string tokens = baseRef.Tokenize("Sample input for tokenization");
            System.Console.WriteLine("Tokenize() returned: " + tokens);
            System.Console.WriteLine("SelfAttention() returned: " + transformerRef.SelfAttention(tokens));

            System.Console.WriteLine("\n========= END INHERITANCE =========\n");
        }
    }
}
