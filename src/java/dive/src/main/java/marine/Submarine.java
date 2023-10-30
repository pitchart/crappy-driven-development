package marine;

import lombok.Getter;

import java.util.List;

@Getter
public class Submarine {
    private Position position;

    public Submarine(int h, int d) {
        this.position = new Position(h, d);
    }

    public void move(List<Instruction> instructions) {
      for (int i = 0; i < instructions.size(); i++) {
        move(instructions.get(i));
      }
    }

    private void move(Instruction instruction) {
      if (instruction.getText().equals("down")) {
        position = position.withD(position.getD() + instruction.getX());
      } else if (instruction.getText().equals("up")) {
        position = position.withD(position.getD() - instruction.getX());
      } else {
        position = position.withH(position.getH() + instruction.getX());
      }
    }
}