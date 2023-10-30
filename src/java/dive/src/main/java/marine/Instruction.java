package marine;

import lombok.AllArgsConstructor;
import lombok.Getter;

@AllArgsConstructor
@Getter
public class Instruction {
    // What it's supposed to do
    private final String text;

    // How much it's supposed to do it
    private final int x;

    public static Instruction buildFromText(String text) {
        var split = text.split(" ");
        return new Instruction(split[0], Integer.parseInt(split[1]));
    }
}