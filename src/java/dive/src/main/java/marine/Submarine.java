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
      if (!instruction.getText().equals("down")) {
        if (instruction.getText().equals("up")) {
          position = position.withD(subAnInt(instruction));
        } else {
          position = position.withH(addToH(instruction));
        }
      } else {
        position = position.withD(addAnInt(instruction));
      }
    }

  private int addToH(Instruction instruction) {
    return position.getH() + instruction.getX();
  }

  private int subAnInt(Instruction instruction) {
    return position.getD() - instruction.getX();
  }

  private int addAnInt(Instruction instruction) {
    return position.getD() + instruction.getX();
  }
}