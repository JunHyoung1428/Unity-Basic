using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

//========================================
//##			������ ���� MVC			##  
//========================================
/*
	MVC(Model-View-Controller) ���� : 
	����� �������̽�, ������, �������� �и��Ͽ� ���α׷��� �����ϴ� ����

	���� :
	Model
		���α׷��� ������
		Controller�� ���� ����
		�������� ������ View���� �˸�
	View
		����� �������̽�
		Model�� �����͸� ������� ����ڿ��� ���� ǥ��
		����ڿ��� �Է��� �޾� Controller���� �˸�
	Controller	: 
		������
		View�� �Է��� �޾� �������� ó��
		�������� ����� Model�� ����

	���� :
	1. �������� �� ���� �ܼ��ϰ� ��������
	2. ���α׷��� ���� ��Ҹ� ������� ���� ��ĥ �� �ֵ��� ����
	3. ����������, ���ø����̼��� Ȯ�强, �������� �ڵ����뼺�� ������

	���� :
	1. Model�� View�� �������� ����

	�׿� :
	MVC ������ �Ļ����� MVP(Model-View-Presenter), MVVM(Model-View-ViewModel) ������ ���� (https://programmingdev.com/unity-%EB%94%94%EC%9E%90%EC%9D%B8-%ED%8C%A8%ED%84%B4-mvc-mvp-mvvm-%EB%B9%84%EA%B5%90-%EB%B0%8F-%EC%98%88%EC%8B%9C-%EC%BD%94%EB%93%9C/)
    �ٽ��� �����Ϳ�(Model) UI(View)�� �� �и��ؼ� �����ϴ� ��.
                => ����Ƽ�� MVC������ �ָ��ؼ� MVP, MVVM �� ���� ������ ������ Ȱ���ϱ⵵��
*/

public class Model
{
    private int data;
    public int Data
    {
        set
        {
            Debug.Log("[Model] Model changed event");
            OnDataChanged?.Invoke(value);
            data = value;
        }
        get
        {
            return data;
        }
    }

    public UnityAction<int> OnDataChanged;
}

public class View
{
    public UnityAction OnInputed;

    public void UpdateData(int data)
    {
        Debug.Log("[View] Set data");
    }

    public void Input()
    {
        Debug.Log("[View] Detect input");
        OnInputed?.Invoke();
    }
}

public class Controller
{
    public Model data;

    public void Logic()
    {
        Debug.Log("[Controller] Logic");
        data.Data += 1;
    }
}

public class MVCTester
{
    public void Test()
    {
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller();

        model.OnDataChanged += view.UpdateData;
        view.OnInputed += controller.Logic;
        controller.data = model;

        view.Input();
        // 1. [View] Dectect input
        // 2. [Controller] Logic
        // 3. [Model] Model change event
        // 4. [View] Set Data
    }
}

public class MVC
{

}
