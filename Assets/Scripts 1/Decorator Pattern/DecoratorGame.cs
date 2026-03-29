using UnityEngine;

public class DecoratorGame : MonoBehaviour
{
    void Start()
    {
        IDamage damage = new BaseDamage(10); // tạo ra damage vs damage cơ bản là 10
        damage = new DamageBuff(damage, 5); // lấy damage vừa tạo ra và thêm 5 vào damage đó
        damage = new DamageBuff(damage, 3); // lấy damage vừa tạo ra và thêm 3 vào damage đó

        // hiểu đơn giản là ban đầu tạo ra dame vs 10
        // khởi tạo 1 cái buffdamage có biến là interface damage vừa tạo ra và trong đó có 5 dame bonus
        // tiếp tục lấy cái vừa tạo buffdamage đó và tạo ra 1 buffdamage nữa có biến là damage vừa tạo ra và trong đó có 3 dame bonus

        // tức là interface A : 10 (dòng 1)
        // dòng 2 tạo ra 1 cái ms chứa interface A, int bonus 5 gọi là interface B
        // dòng 3 tạo ra 1 cái ms chứa interface B, int bonus 3 gọi là interface C

        // => quy trình gọi damage.GetDamage() sẽ như sau:
        // lấy thg tạo ra sau cùng tức interface C
        // return base.GetDamage() + bonus;
        // tức là 3 + base.GetDamage() => gọi đến interface B base.GetDamage
        // -> gọi interface.Getdamage mà ta set nãy chính là cụm này đấy
        // cụm đó GetDamage -> base.GetDamage() thì +5 bonus và lại lấy interface A ta setup vào base gọi GetDamage()
        // interface A là base damage là 10 k gọi base.GetDamage() nữa
        Debug.Log("Final Damage: " + damage.GetDamage());
    }
}
