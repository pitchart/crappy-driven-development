package marine;

import lombok.AllArgsConstructor;
import lombok.Getter;
import lombok.With;

@AllArgsConstructor
@With
@Getter
public class Position {
    // horizontal position
    private final int h;

    // depth position
    private final int d;
}