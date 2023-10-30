package marine;

import lombok.Getter;

import java.util.List;

@Getter
public class Submarine {
    private Position position;

    public Submarine(int horizontal, int depth) {
        this.position = new Position(horizontal, depth);
    }

    public void move(List<Instruction> instructions) {
      for (int i = 0; i < instructions.size(); i++) {
        move(instructions.get(i));
      }
    }

    private void move(Instruction instruction) {
      if (instruction.getText().equals("down")) {
        position = position.withDepth(position.getDepth() + instruction.getX());
      } else if (instruction.getText().equals("up")) {
        position = position.withDepth(position.getDepth() - instruction.getX());
      } else {
        position = position.withHorizontal(position.getHorizontal() + instruction.getX());
      }
    }
}